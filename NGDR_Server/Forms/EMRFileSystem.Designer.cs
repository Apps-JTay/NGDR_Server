namespace NGDR_Server.Forms
{
    partial class EMRFileSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblAppVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDB = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDocLocation = new Infragistics.Win.Misc.UltraLabel();
            this.btnSave = new Infragistics.Win.Misc.UltraButton();
            this.btnDelete = new Infragistics.Win.Misc.UltraButton();
            this.txtDocPath = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.btnBrowseDP = new Infragistics.Win.Misc.UltraButton();
            this.lblLocPath = new Infragistics.Win.Misc.UltraLabel();
            this.btnSaveLocal = new Infragistics.Win.Misc.UltraButton();
            this.btnDeleteLocal = new Infragistics.Win.Misc.UltraButton();
            this.txtLocalPath = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.btnBrowseLP = new Infragistics.Win.Misc.UltraButton();
            this.lblImageZipPath = new Infragistics.Win.Misc.UltraLabel();
            this.btnSaveImageZip = new Infragistics.Win.Misc.UltraButton();
            this.btnDeleteImageZip = new Infragistics.Win.Misc.UltraButton();
            this.txtImageZip = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.btnBrowseIZ = new Infragistics.Win.Misc.UltraButton();
            this.lblImageExtractPath = new Infragistics.Win.Misc.UltraLabel();
            this.btnSaveImageExtract = new Infragistics.Win.Misc.UltraButton();
            this.btnImageExtractDelete = new Infragistics.Win.Misc.UltraButton();
            this.txtImageExtract = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.btnBrowseIE = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.btnSaveGC = new Infragistics.Win.Misc.UltraButton();
            this.btnDeleteGC = new Infragistics.Win.Misc.UltraButton();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.btnSaveAppt = new Infragistics.Win.Misc.UltraButton();
            this.btnDeleteAppt = new Infragistics.Win.Misc.UltraButton();
            this.uneGC = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.neAppt = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.btnSaveAll = new Infragistics.Win.Misc.UltraButton();
            this.btnDeleteAll = new Infragistics.Win.Misc.UltraButton();
            this.btnClose = new Infragistics.Win.Misc.UltraButton();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageZip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageExtract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneGC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neAppt)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblAppVersion,
            this.lblDB,
            this.lblFVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 387);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(81, 17);
            this.lblAppVersion.Text = "lblAppVersion";
            // 
            // lblDB
            // 
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(35, 17);
            this.lblDB.Text = "lblDB";
            // 
            // lblFVersion
            // 
            this.lblFVersion.Name = "lblFVersion";
            this.lblFVersion.Size = new System.Drawing.Size(65, 17);
            this.lblFVersion.Text = "lblFVersion";
            // 
            // lblDocLocation
            // 
            this.lblDocLocation.Location = new System.Drawing.Point(12, 17);
            this.lblDocLocation.Name = "lblDocLocation";
            this.lblDocLocation.Size = new System.Drawing.Size(191, 23);
            this.lblDocLocation.TabIndex = 1;
            this.lblDocLocation.Text = "Path to Documents on NextGenRoot";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(280, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(361, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            // 
            // txtDocPath
            // 
            this.txtDocPath.Location = new System.Drawing.Point(13, 43);
            this.txtDocPath.Name = "txtDocPath";
            this.txtDocPath.Size = new System.Drawing.Size(664, 21);
            this.txtDocPath.TabIndex = 4;
            // 
            // btnBrowseDP
            // 
            this.btnBrowseDP.Location = new System.Drawing.Point(698, 40);
            this.btnBrowseDP.Name = "btnBrowseDP";
            this.btnBrowseDP.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDP.TabIndex = 5;
            this.btnBrowseDP.Text = "Browse";
            // 
            // lblLocPath
            // 
            this.lblLocPath.Location = new System.Drawing.Point(12, 92);
            this.lblLocPath.Name = "lblLocPath";
            this.lblLocPath.Size = new System.Drawing.Size(224, 23);
            this.lblLocPath.TabIndex = 6;
            this.lblLocPath.Text = "Path on machine to save the temp directory";
            // 
            // btnSaveLocal
            // 
            this.btnSaveLocal.Location = new System.Drawing.Point(280, 87);
            this.btnSaveLocal.Name = "btnSaveLocal";
            this.btnSaveLocal.Size = new System.Drawing.Size(75, 23);
            this.btnSaveLocal.TabIndex = 7;
            this.btnSaveLocal.Text = "Save";
            // 
            // btnDeleteLocal
            // 
            this.btnDeleteLocal.Location = new System.Drawing.Point(361, 87);
            this.btnDeleteLocal.Name = "btnDeleteLocal";
            this.btnDeleteLocal.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteLocal.TabIndex = 8;
            this.btnDeleteLocal.Text = "Delete";
            // 
            // txtLocalPath
            // 
            this.txtLocalPath.Location = new System.Drawing.Point(13, 122);
            this.txtLocalPath.Name = "txtLocalPath";
            this.txtLocalPath.Size = new System.Drawing.Size(664, 21);
            this.txtLocalPath.TabIndex = 9;
            // 
            // btnBrowseLP
            // 
            this.btnBrowseLP.Location = new System.Drawing.Point(698, 122);
            this.btnBrowseLP.Name = "btnBrowseLP";
            this.btnBrowseLP.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseLP.TabIndex = 10;
            this.btnBrowseLP.Text = "Browse";
            // 
            // lblImageZipPath
            // 
            this.lblImageZipPath.Location = new System.Drawing.Point(13, 166);
            this.lblImageZipPath.Name = "lblImageZipPath";
            this.lblImageZipPath.Size = new System.Drawing.Size(223, 23);
            this.lblImageZipPath.TabIndex = 11;
            this.lblImageZipPath.Text = "Path to image ZIP file";
            // 
            // btnSaveImageZip
            // 
            this.btnSaveImageZip.Location = new System.Drawing.Point(280, 161);
            this.btnSaveImageZip.Name = "btnSaveImageZip";
            this.btnSaveImageZip.Size = new System.Drawing.Size(75, 23);
            this.btnSaveImageZip.TabIndex = 12;
            this.btnSaveImageZip.Text = "Save";
            // 
            // btnDeleteImageZip
            // 
            this.btnDeleteImageZip.Location = new System.Drawing.Point(361, 161);
            this.btnDeleteImageZip.Name = "btnDeleteImageZip";
            this.btnDeleteImageZip.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteImageZip.TabIndex = 13;
            this.btnDeleteImageZip.Text = "Delete";
            // 
            // txtImageZip
            // 
            this.txtImageZip.Location = new System.Drawing.Point(13, 191);
            this.txtImageZip.Name = "txtImageZip";
            this.txtImageZip.Size = new System.Drawing.Size(664, 21);
            this.txtImageZip.TabIndex = 14;
            // 
            // btnBrowseIZ
            // 
            this.btnBrowseIZ.Location = new System.Drawing.Point(698, 191);
            this.btnBrowseIZ.Name = "btnBrowseIZ";
            this.btnBrowseIZ.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseIZ.TabIndex = 15;
            this.btnBrowseIZ.Text = "Browse";
            // 
            // lblImageExtractPath
            // 
            this.lblImageExtractPath.Location = new System.Drawing.Point(13, 240);
            this.lblImageExtractPath.Name = "lblImageExtractPath";
            this.lblImageExtractPath.Size = new System.Drawing.Size(223, 23);
            this.lblImageExtractPath.TabIndex = 16;
            this.lblImageExtractPath.Text = "Path to extract image files";
            // 
            // btnSaveImageExtract
            // 
            this.btnSaveImageExtract.Location = new System.Drawing.Point(280, 235);
            this.btnSaveImageExtract.Name = "btnSaveImageExtract";
            this.btnSaveImageExtract.Size = new System.Drawing.Size(75, 23);
            this.btnSaveImageExtract.TabIndex = 17;
            this.btnSaveImageExtract.Text = "Save";
            // 
            // btnImageExtractDelete
            // 
            this.btnImageExtractDelete.Location = new System.Drawing.Point(361, 235);
            this.btnImageExtractDelete.Name = "btnImageExtractDelete";
            this.btnImageExtractDelete.Size = new System.Drawing.Size(75, 23);
            this.btnImageExtractDelete.TabIndex = 18;
            this.btnImageExtractDelete.Text = "Delete";
            // 
            // txtImageExtract
            // 
            this.txtImageExtract.Location = new System.Drawing.Point(13, 265);
            this.txtImageExtract.Name = "txtImageExtract";
            this.txtImageExtract.Size = new System.Drawing.Size(664, 21);
            this.txtImageExtract.TabIndex = 19;
            // 
            // btnBrowseIE
            // 
            this.btnBrowseIE.Location = new System.Drawing.Point(698, 262);
            this.btnBrowseIE.Name = "btnBrowseIE";
            this.btnBrowseIE.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseIE.TabIndex = 20;
            this.btnBrowseIE.Text = "Browse";
            // 
            // ultraLabel1
            // 
            this.ultraLabel1.Location = new System.Drawing.Point(13, 297);
            this.ultraLabel1.Name = "ultraLabel1";
            this.ultraLabel1.Size = new System.Drawing.Size(152, 23);
            this.ultraLabel1.TabIndex = 21;
            this.ultraLabel1.Text = "Days till garbage collection";
            // 
            // btnSaveGC
            // 
            this.btnSaveGC.Location = new System.Drawing.Point(172, 293);
            this.btnSaveGC.Name = "btnSaveGC";
            this.btnSaveGC.Size = new System.Drawing.Size(75, 23);
            this.btnSaveGC.TabIndex = 22;
            this.btnSaveGC.Text = "Save";
            // 
            // btnDeleteGC
            // 
            this.btnDeleteGC.Location = new System.Drawing.Point(254, 293);
            this.btnDeleteGC.Name = "btnDeleteGC";
            this.btnDeleteGC.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGC.TabIndex = 23;
            this.btnDeleteGC.Text = "Delete";
            // 
            // ultraLabel2
            // 
            this.ultraLabel2.Location = new System.Drawing.Point(361, 292);
            this.ultraLabel2.Name = "ultraLabel2";
            this.ultraLabel2.Size = new System.Drawing.Size(100, 23);
            this.ultraLabel2.TabIndex = 24;
            this.ultraLabel2.Text = "Appt # days";
            // 
            // btnSaveAppt
            // 
            this.btnSaveAppt.Location = new System.Drawing.Point(468, 292);
            this.btnSaveAppt.Name = "btnSaveAppt";
            this.btnSaveAppt.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAppt.TabIndex = 25;
            this.btnSaveAppt.Text = "Save";
            // 
            // btnDeleteAppt
            // 
            this.btnDeleteAppt.Location = new System.Drawing.Point(550, 292);
            this.btnDeleteAppt.Name = "btnDeleteAppt";
            this.btnDeleteAppt.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAppt.TabIndex = 26;
            this.btnDeleteAppt.Text = "Delete";
            // 
            // uneGC
            // 
            this.uneGC.Location = new System.Drawing.Point(13, 323);
            this.uneGC.Name = "uneGC";
            this.uneGC.Size = new System.Drawing.Size(100, 21);
            this.uneGC.TabIndex = 27;
            // 
            // neAppt
            // 
            this.neAppt.Location = new System.Drawing.Point(361, 321);
            this.neAppt.Name = "neAppt";
            this.neAppt.Size = new System.Drawing.Size(100, 21);
            this.neAppt.TabIndex = 28;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(13, 351);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(87, 23);
            this.btnSaveAll.TabIndex = 29;
            this.btnSaveAll.Text = "Save All";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(107, 351);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAll.TabIndex = 30;
            this.btnDeleteAll.Text = "Delete All";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(188, 351);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            // 
            // EMRFileSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.neAppt);
            this.Controls.Add(this.uneGC);
            this.Controls.Add(this.btnDeleteAppt);
            this.Controls.Add(this.btnSaveAppt);
            this.Controls.Add(this.ultraLabel2);
            this.Controls.Add(this.btnDeleteGC);
            this.Controls.Add(this.btnSaveGC);
            this.Controls.Add(this.ultraLabel1);
            this.Controls.Add(this.btnBrowseIE);
            this.Controls.Add(this.txtImageExtract);
            this.Controls.Add(this.btnImageExtractDelete);
            this.Controls.Add(this.btnSaveImageExtract);
            this.Controls.Add(this.lblImageExtractPath);
            this.Controls.Add(this.btnBrowseIZ);
            this.Controls.Add(this.txtImageZip);
            this.Controls.Add(this.btnDeleteImageZip);
            this.Controls.Add(this.btnSaveImageZip);
            this.Controls.Add(this.lblImageZipPath);
            this.Controls.Add(this.btnBrowseLP);
            this.Controls.Add(this.txtLocalPath);
            this.Controls.Add(this.btnDeleteLocal);
            this.Controls.Add(this.btnSaveLocal);
            this.Controls.Add(this.lblLocPath);
            this.Controls.Add(this.btnBrowseDP);
            this.Controls.Add(this.txtDocPath);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDocLocation);
            this.Controls.Add(this.statusStrip1);
            this.Name = "EMRFileSystem";
            this.Text = "EMR File System";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageZip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImageExtract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uneGC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neAppt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblAppVersion;
        private System.Windows.Forms.ToolStripStatusLabel lblDB;
        private System.Windows.Forms.ToolStripStatusLabel lblFVersion;
        private Infragistics.Win.Misc.UltraLabel lblDocLocation;
        private Infragistics.Win.Misc.UltraButton btnSave;
        private Infragistics.Win.Misc.UltraButton btnDelete;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtDocPath;
        private Infragistics.Win.Misc.UltraButton btnBrowseDP;
        private Infragistics.Win.Misc.UltraLabel lblLocPath;
        private Infragistics.Win.Misc.UltraButton btnSaveLocal;
        private Infragistics.Win.Misc.UltraButton btnDeleteLocal;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtLocalPath;
        private Infragistics.Win.Misc.UltraButton btnBrowseLP;
        private Infragistics.Win.Misc.UltraLabel lblImageZipPath;
        private Infragistics.Win.Misc.UltraButton btnSaveImageZip;
        private Infragistics.Win.Misc.UltraButton btnDeleteImageZip;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtImageZip;
        private Infragistics.Win.Misc.UltraButton btnBrowseIZ;
        private Infragistics.Win.Misc.UltraLabel lblImageExtractPath;
        private Infragistics.Win.Misc.UltraButton btnSaveImageExtract;
        private Infragistics.Win.Misc.UltraButton btnImageExtractDelete;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtImageExtract;
        private Infragistics.Win.Misc.UltraButton btnBrowseIE;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private Infragistics.Win.Misc.UltraButton btnSaveGC;
        private Infragistics.Win.Misc.UltraButton btnDeleteGC;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraButton btnSaveAppt;
        private Infragistics.Win.Misc.UltraButton btnDeleteAppt;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneGC;
        private Infragistics.Win.UltraWinEditors.UltraNumericEditor neAppt;
        private Infragistics.Win.Misc.UltraButton btnSaveAll;
        private Infragistics.Win.Misc.UltraButton btnDeleteAll;
        private Infragistics.Win.Misc.UltraButton btnClose;
    }
}