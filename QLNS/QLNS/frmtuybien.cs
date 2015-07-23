using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNS
{
    public partial class frmtuybien : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public frmtuybien()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clsdatabase.mabophan = comboBox2.Text;
            Clsdatabase.maphongb = comboBox3.Text;
            Clsdatabase.bao = 1;
            DataSet ds1 = new DataSet();
            String x = comboBox2.Text;
            String y = comboBox3.Text;
            cls.loaddatagridview(dataGridView2, "select * from TblTTNVCoBan where MaBoPhan ='" + x + "' and MaPhong ='" + y + "'");
            
        }

        private void frmtuybien_Load(object sender, EventArgs e)
        {
            cls.loadcombobox(comboBox2, "select * from TblTTNVCoBan", 0);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            String x = comboBox2.Text;
            cls.loadcombobox(comboBox3, "select * from TblPhongBan where MaBoPhan ='"+x+"'", 1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmCry_hienthitheophongban pb = new frmCry_hienthitheophongban();
            pb.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCry_hienthitheophongban pb = new frmCry_hienthitheophongban();
            pb.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clsdatabase.tg = textBox20.Text;
            Clsdatabase.bao = 2;
            DataSet ds1 = new DataSet();
            cls.loaddatagridview(dataGridView1, "select * from TblTTNVCoBan where ChucVu ='" + textBox20.Text +"'");
        }
    }
}
