using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JTay.FrameWork;
using JTay.FrameWork.Enumerators;
using JTay.FrameWork.Interfaces;
using JTay.FrameWork.Support;
using JTay.NextGen;
using Microsoft.VisualBasic.Logging;

namespace NGDR_Server
{
    public partial class DR_Server : Form
    {
        private readonly bool fromCMD;
        private readonly string location;
        private readonly bool sameProvider;
        private readonly bool limitEnc;
        private readonly bool unZip;
        private readonly int limitNum;
        private static readonly  IDataLayer ssDataLayer = DataLayerFactory.CreateDataLayer(DataSourceType.MsSql, ConnectionStrings.ConnectionString("FT"));

        private readonly ArrayList LocationList = new ArrayList();

        public DR_Server()
        {
            InitializeComponent();
        }

        public DR_Server(string passedLoc, bool passesPro, bool passedEnc, int encnum, bool passedUnZip)
        {
            InitializeComponent();
            location = passedLoc;
            sameProvider = passesPro;
            limitEnc = passedEnc;
            limitNum = encnum;
            fromCMD = true;
            unZip = passedUnZip;
        }

        private void DR_Server_Load(object sender, EventArgs e)
        {

            //lblFVersion.Text = Config.Version;
            //lblAppVersion.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version;
            //lblDB.Text = Config.PrimaryDBName;

            BindLocations();
            CollectDocsGarbage();
            CollectImagesGarbage();
            if (!fromCMD) return;
            cbLimitEnc.Checked = limitEnc;
            uneEncCount.Value = limitNum;
            if (unZip)
                UnZipFiles();
            else
            
                CreateFilesToTransfer();
            

        }

        private void CreateFilesToTransfer()
        {
            DataTable table;
            DateTime dateToUse;
            if (!fromCMD)
            {
                Cursor = Cursors.WaitCursor;
                if (cmbLocation.Text != "  --  Choose One  --  ")
                {
                    dateToUse = Convert.ToDateTime(dtApptDate.Value);
                    table = EMRFileCreator.ExistingDocuments(cmbLocation.SelectedValue.ToString(), dateToUse, cbSameProvider.Checked, ApptDays);
                }
                else
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show("You must select a location", "Missing Location", 0, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                dateToUse = DateTime.Now.AddDays(1);
                table = EMRFileCreator.ExistingDocuments(location, dateToUse, sameProvider, ApptDays);
            }

            CreateFilesToZip(table, dateToUse);
            Cursor = Cursors.Default;
        }
        private static string GetPath(string item)
        {
            string path = Config.ProjectDirectory + "\\efs.JTC";
            string docPath = string.Empty;
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] parts = reader.ReadLine().Split('|');
                        if (parts[0] == item)
                        {
                            return parts[1];
                        }
                    }
                }
            }

            return docPath;
        }

        private void BindLocations()
        {
            DataTable locations = CommonObjectsList.DisplayLocations(true, true);
            cmbLocation.DataSource = locations;
            cmbLocation.DisplayMember = "location_name";
            cmbLocation.ValueMember = "location_id";

            foreach (DataRow row in locations.Rows)
            {
                if(row["location_id"].ToString()== "00000000-0000-0000-0000-000000000000") continue;
                string loc_id = "'" + row["location_id"] + "'";
                if (!LocationList.Contains(loc_id))
                    LocationList.Add(loc_id);
            }
        }

        private static void CollectImagesGarbage()
        {
            string imageZipPath = GetPath("IZ");
            if (!Directory.Exists(imageZipPath)) return;
            imageZipPath += "UnZipped\\";
            if (!Directory.Exists(imageZipPath)) return;
            foreach (string file in Directory.GetFiles(imageZipPath))
            {
                if (File.GetLastAccessTime(file) < DateTime.Now.AddDays(GCDays))
                {
                    File.Delete(file);
                    Log log = new Log(ssDataLayer)
                    {
                        FileName = "From Images Directory - " + file,
                        Image = false,
                        Action = Actions.Remove,
                        Date_created = DateTime.Now,
                        Machine = Environment.MachineName
                    };
                    log.Save(); 
                }
            }
        }

        private static void CollectDocsGarbage()
        {
            string localPath = GetPath("LP");
            if (!Directory.Exists(localPath)) return;
            foreach (string directory in Directory.GetDirectories(localPath))
            {
                foreach (string subDirectory in Directory.GetDirectories(directory))
                {
                    if (Directory.GetLastAccessTime(subDirectory) < DateTime.Now.AddDays(GCDays))
                    {
                        Directory.Delete(subDirectory, true);

                        Log log = new Log(ssDataLayer)
                        {
                            FileName = "From EMR Directory - " + subDirectory,
                            Image = false,
                            Action = Actions.Remove,
                            Date_created = DateTime.Now,
                            Machine = Environment.MachineName
                        };
                        log.Save();
                    }
                }
            }
        }
        private void CreateFilesToZip(DataTable table, DateTime dateToUse)
        {
            string docPath = GetPath("DP");
            string localPath = GetPath("LP");
            if (!string.IsNullOrEmpty(docPath) && !String.IsNullOrEmpty(localPath))
            {
                ArrayList people = new ArrayList();
                foreach (DataRow row in table.Rows)
                {
                    string fileToCopy = docPath + row["document_file"];
                    string fileName = localPath + row["document_file"];
                    File.Copy(fileToCopy, fileName, true);


                    string person_id = "'" + row["person_id"] + "'";
                    if (!people.Contains(person_id))
                        people.Add(person_id);
                }
                foreach (string loc in LocationList)
                {
                    DataView view = new DataView(table) { RowFilter = ("location_id = " + loc) };
                    if (view.Count > 0)
                    {
                        string loc_name = view[0]["location_name"].ToString();
                        string tempDir = localPath + loc_name + "\\" + dateToUse.ToString("MMMM_dd_yyyy");
                        if (!Directory.Exists(tempDir))
                            Directory.CreateDirectory(tempDir);

                        foreach (string person in people)
                        {
                            view.RowFilter = "location_id =" + loc + " AND person_id = " + person;
                            if (view.Count <= 0) continue;
                            string person_name = view[0]["first_name"] + "_" + view[0]["last_name"];

                            ArrayList Encounters = new ArrayList();
                            foreach (DataRowView rowView in view)
                            {
                                if ((cbLimitEnc.Checked && Encounters.Count < (int)uneEncCount.Value) ||
                                    !cbLimitEnc.Checked)
                                {
                                    string item = "'" + rowView["enc_id"] + "'";
                                    if (!Encounters.Contains(item))
                                        Encounters.Add(item);
                                }
                            }
                            foreach (string encounter in Encounters)
                            {
                                view.RowFilter = "location_id =" + loc + " AND person_id = " + person + " AND enc_id=" +
                                                 encounter;
                                foreach (DataRowView rowView in view)
                                {
                                    string fileName = tempDir + "\\" + person_name + "_" + rowView["document_desc"] +
                                                      "_" +
                                                      Convert.ToDateTime(rowView["create_timestamp"]).ToString(
                                                          "MM_dd_yyyy_hh_mm_tt") + ".doc";

                                    string fileToCopy = localPath + rowView["document_file"];
                                    if (!File.Exists(fileToCopy)) continue;
                                    File.Copy(fileToCopy, fileName, true);
                                    File.Delete(fileToCopy);
                                }
                            }
                        }

                        ZipFiles(tempDir, dateToUse, loc_name);
                    }
                    else
                    {

                        string locid = loc.Replace("'", "");
                        string name = "";
                        foreach (DataRowView item in cmbLocation.Items)
                        {
                            string s = item[0].ToString();
                            if (s != locid) continue;
                            name = item[1].ToString();
                            break;
                        }

                        string subject = "There were no files to zip for " + name;
                        string message = subject + "\n\n\nThis message generated by " + Environment.MachineName;
                        if (cmbLocation.Text == "  --  All  --  " || cmbLocation.ValueMember == locid)
                            SendEmail(subject, message, MailPriority.Normal);
                    }
                }
                if (!fromCMD)
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show("Successfully created and zipped directories");
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Please Make sure your EMR Document Path is Set", "Missing Document Path", 0,
                                MessageBoxIcon.Error);
            }
        }

        private static string Emails
        {
            get
            {
                string emails = "admin@j-tay.com";
                if (!File.Exists(Config.ProjectDirectory + "\\emc.jtc")) return emails;
                using (StreamReader reader = new StreamReader(Config.ProjectDirectory + "\\emc.jtc"))
                {

                    emails = reader.ReadToEnd();

                }
                if (string.IsNullOrEmpty(emails))
                    emails = "admin@J-Tay.com";
                return emails;

            }
        }
        private static void SendEmail(string subject, string message, MailPriority priority)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(Emails);
            mailMessage.From = new MailAddress("admin@J-Tay.com", "EMR Nightly File Creator");
            mailMessage.Subject = subject;
            mailMessage.Priority = priority;
            mailMessage.Body = message;
            mailMessage.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("tinman", 25) { UseDefaultCredentials = true };
            client.Send(mailMessage);
        }
        private static int GCDays
        {
            get
            {
                string temp = GetPath("GC");
                if (StringUtility.IsNumeric(temp, NumberStyles.Number))
                    return Convert.ToInt32(temp) * -1;
                return -3;

            }
        }

        private static void ZipFiles(string tempDir, DateTime dateToUse, string location_name)
        {
            string zipFile = "EMR_" + dateToUse.ToString("MM_dd_yyyy") + ".kjzip";
            ArrayList filesToZip = new ArrayList();

            foreach (string file in Directory.GetFiles(tempDir))
            {
                FileInfo info = new FileInfo(file);
                if (info.Extension != ".kjzip")
                {
                    filesToZip.Add(file);
                    Log log = new Log(ssDataLayer)
                    {
                        FileName = file,
                        Image = false,
                        Action = Actions.Zip,
                        Date_created = DateTime.Now,
                        Machine = Environment.MachineName
                    };
                    log.Save();
                }
            }


            ZipFileHelper.CreateZipFile(tempDir + "\\" + zipFile, (string[])filesToZip.ToArray(typeof(string)));
            string message = filesToZip.Count + " were zipped for "
                             + location_name + " by " + Environment.MachineName;
            message += "<br /><a href=\"http://SSLog/log.aspx?d=" + DateTime.Now.ToString("yyyy/MM/dd") + "&a=" + (int)Actions.Zip + "&l=" + location_name + "\">Click to see which files were Zipped for " + location_name + " </>";
            string ssServer = SiteServers.MachineNameForLocation(ssDataLayer, location_name);
            if (!string.IsNullOrEmpty(ssServer) && ssServer != "Network")
                message += "<br /><a href=\"http://" + ssServer + "/SSLog_root/log.aspx?d=" + DateTime.Now.ToString("yyyy/MM/dd") + "&a=" + (int)Actions.Unzip + "\">Click to see which files were unzipped by the Site Server at this location</>";
            else
            {
                message += "<br /><a href=\"http://SSLog/log.aspx?d=" + DateTime.Now.ToString("yyyy/MM/dd") + "&a=" + (int)Actions.Unzip + "&l=" + location_name + "\">Click to see which files were Unzipped for " + location_name + " </>";
            }


            string subject = "Files Zipped for " + location_name + " by " + Environment.MachineName;
            SendEmail(subject, message, MailPriority.Normal);
        }

        private void UnZipFiles()
        {
            string zippath = GetPath("IZ");
            string extractPath = GetPath("IE");

            if (String.IsNullOrEmpty(zippath) || String.IsNullOrEmpty(extractPath)) return;
            string unzipped = zippath + "UnZipped\\";
            if (!Directory.Exists(unzipped))
                Directory.CreateDirectory(unzipped);
            string moveTo = zippath + "Temp\\";
            if (!Directory.Exists(moveTo))
                Directory.CreateDirectory(moveTo);

            foreach (string file in Directory.GetFiles(moveTo))
            {
                FileInfo info = new FileInfo(file);
                if (info.Extension.ToLower() != ".jtzip") continue;
                string dir = info.DirectoryName;
                string movedFile = file.Replace(dir, unzipped);
                if (File.Exists(movedFile))
                    File.Delete(movedFile);
                File.Move(file, movedFile);
            }

            foreach (string file in Directory.GetFiles(zippath))
            {
                FileInfo info = new FileInfo(file);
                if (info.Extension.ToLower() != ".jtzip") continue;
                string dir = info.DirectoryName;
                string movedFile = file.Replace(dir, moveTo);
                if (File.Exists(movedFile))
                    File.Delete(movedFile);
                File.Move(file, movedFile);
            }
            foreach (string file in Directory.GetFiles(moveTo))
            {
                ZipFileHelper.ExtractZipFile(file, extractPath);
            }

            ArrayList emailList = new ArrayList();
            AddItemsToEmail(extractPath, emailList);


            if (!fromCMD) return;

            string subject = "Images Unzipped by " + Environment.MachineName;
            string message = "<br />" + emailList.Count + " " + subject;
            message += "<br /><a href=\"http://SSLog/log.aspx?d=" + DateTime.Now.ToString("yyyy/MM/dd") + "&a=" + (int)Actions.Unzip + "\">Click to see which files were Unzipped</>";

            SendEmail(subject, message, MailPriority.Normal);
            Application.Exit();
        }


    }
}
