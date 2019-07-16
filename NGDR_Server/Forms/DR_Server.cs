using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JTay.FrameWork;
using JTay.FrameWork.Enumerators;
using JTay.FrameWork.Interfaces;
using JTay.FrameWork.Support;

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
        private  static readonly  IDataLayer ssDataLayer = DataLayerFactory.CreateDataLayer(DataSourceType.MsSql, ConnectionStrings.ConnectionString("FT"));

        private readonly ArrayList locationList = new ArrayList();

        public DR_Server()
        {
            InitializeComponent();
        }
    }
}
