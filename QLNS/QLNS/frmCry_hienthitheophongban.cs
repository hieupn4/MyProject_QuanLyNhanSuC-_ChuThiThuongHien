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
    public partial class frmCry_hienthitheophongban : Form
    {
        ReportDocument rptt = new ReportDocument();
        string connstr = @"Data Source=ACER-PC\SQLEXPRESS;Initial Catalog=QLNS2;Integrated Security=True";
        public frmCry_hienthitheophongban()
        {
            InitializeComponent();
        }

        private void frmCry_hienthitheophongban_Load(object sender, EventArgs e)
        {
            if (Clsdatabase.bao == 1)
            {
                String x = Clsdatabase.mabophan;
                String y = Clsdatabase.maphongb;
                SqlConnection sqlcon = new SqlConnection(connstr);
                string select = "select * from TblTTNVCoBan where MaBoPhan ='" + x + "' AND MaPhong ='" + y + "'";
                sqlcon.Open();
                SqlDataAdapter ada = new SqlDataAdapter(select, sqlcon);
                DataSet ds1 = new DataSet();
                ada.Fill(ds1, "TblTTNVCoBan");
                rptt.Load(@"C:\Users\ACER\Desktop\QLNS\QLNS\Cry_hien_thi_theo_phongban.rpt");
                rptt.SetDataSource(ds1);
                crystalReportViewer1.ReportSource = rptt;
            }
            else
            {
                String x = Clsdatabase.tg;
                SqlConnection sqlcon = new SqlConnection(connstr);
                string select = "select * from TblTTNVCoBan where ChucVu ='" +x+ "'";
                sqlcon.Open();
                SqlDataAdapter ada = new SqlDataAdapter(select, sqlcon);
                DataSet ds1 = new DataSet();
                ada.Fill(ds1, "TblTTNVCoBan");
                rptt.Load(@"C:\Users\ACER\Desktop\QLNS\QLNS\Cry_hien_thi_theo_phongban.rpt");
                rptt.SetDataSource(ds1);
                crystalReportViewer1.ReportSource = rptt;
            }

        }
    }
}
