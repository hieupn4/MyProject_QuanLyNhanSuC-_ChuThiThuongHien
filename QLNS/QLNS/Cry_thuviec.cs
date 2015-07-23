using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace QLNS
{
    public partial class Cry_thuviec : Form
    {
        ReportDocument rptt = new ReportDocument();
        string connstr = @"Data Source=ACER-PC\SQLEXPRESS;Initial Catalog=QLNS2;Integrated Security=True";
        public Cry_thuviec()
        {
            InitializeComponent();
        }

        private void Cry_thuviec_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(connstr);
            string select = "select * from TblHoSoThuViec";
            sqlcon.Open();
            SqlDataAdapter ada = new SqlDataAdapter(select, sqlcon);
            DataSet ds1 = new DataSet();
            ada.Fill(ds1, "TblHoSoThuViec");
            rptt.Load(@"C:\Users\ACER\Desktop\QLNS\QLNS\Cry_thuviec_.rpt");
            rptt.SetDataSource(ds1);
            crystalReportViewer1.ReportSource = rptt;
        }
    }
}
