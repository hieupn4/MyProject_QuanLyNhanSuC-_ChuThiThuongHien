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
    public partial class Cry_luanchyen : Form
    {
        public Cry_luanchyen()
        {
            InitializeComponent();
        }
        ReportDocument rptt = new ReportDocument();
        string connstr = @"Data Source=ACER-PC\SQLEXPRESS;Initial Catalog=QLNS2;Integrated Security=True";
        public DataTable getnv()
        {
          /* SqlConnection sqlcon = new SqlConnection(connstr);
            string select = "select * from Transfer";
            sqlcon.Open();
            SqlDataAdapter ada = new SqlDataAdapter(select, sqlcon);
            DataSet ds1 = new DataSet();
            ada.Fill(ds1, "Transfer");
            rptt.Load(@"C:\Users\ACER\Desktop\QLNS\QLNS\Cry_luan_chuyen.rpt");
            rptt.SetDataSource(ds1);
            crystalReportViewer1.ReportSource = rptt;
            ds1.Tables["Transfer"].Clear();
            ada.Fill(ds1, "Transfer");
            return ds1.Tables["Transfer"]; */
            return null;
        }
        private void Cry_luanchyen_Load(object sender, EventArgs e)
        {
           /* Cry_luan_chuyen cr = new Cry_luan_chuyen();
            cr.SetDataSource(getnv());
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh(); */
            SqlConnection sqlcon = new SqlConnection(connstr);
            string select = "select * from Transfer";
            sqlcon.Open();
            SqlDataAdapter ada = new SqlDataAdapter(select, sqlcon);
            DataSet ds1 = new DataSet();
            ada.Fill(ds1, "Transfer");
            rptt.Load(@"C:\Users\ACER\Desktop\QLNS\QLNS\Cry_luan_chuyen.rpt");
            rptt.SetDataSource(ds1);
            crystalReportViewer1.ReportSource = rptt;
            
        }
    }
}
