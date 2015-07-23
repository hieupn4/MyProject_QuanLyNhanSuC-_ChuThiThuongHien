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
    public partial class frm_Cry_thaisan : Form
    {
        ReportDocument rptt = new ReportDocument();
        string connstr = @"Data Source=ACER-PC\SQLEXPRESS;Initial Catalog=QLNS2;Integrated Security=True";
        public frm_Cry_thaisan()
        {
            InitializeComponent();
        }

        private void frm_Cry_thaisan_Load(object sender, EventArgs e)
        {
 
            SqlConnection sqlcon = new SqlConnection(connstr);
            string select = "select * from TblThaiSan";
            sqlcon.Open();
            SqlDataAdapter ada = new SqlDataAdapter(select, sqlcon);
            DataSet ds1 = new DataSet();
            ada.Fill(ds1, "TblThaiSan");
            rptt.Load(@"C:\Users\ACER\Desktop\QLNS\QLNS\Cry_thaisan.rpt");
            rptt.SetDataSource(ds1);
            crystalReportViewer1.ReportSource = rptt;
        }
    }
}
