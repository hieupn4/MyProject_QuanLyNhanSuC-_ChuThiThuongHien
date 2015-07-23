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
    public partial class frmKhenThuongKyLuat : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public frmKhenThuongKyLuat()
        {
            InitializeComponent();
        }

        private void frmKhenThuongKyLuat_Load(object sender, EventArgs e)
        {/*
            cls.loadcombobox(comboBox2, "select * from TblTTCaNhan", 0);
            // cls.loadcombobox(comboBox4, "select * from TblBoPhan", 0);
            cls.loaddatagridview(dataGridView1, "select * from TblDanhSachKhenThuong");
            cls.loaddatagridview(dataGridView2, "select * from TblDanhSachKyLuat");
            */

            cls.loaddatagridview(dataGridView1, "select * from TblDanhSachKhenThuong");
            cls.loadcombobox(comboBox2, "select * from TblTTCaNhan", 0);
            cls.loadcombobox(comboBox4, "select * from TblKhenThuong", 0);
            DataSet ds1 = new DataSet();
            cls.loadcombobox(comboBox3, "select * from TblTTCaNhan", 0);
            cls.loaddatagridview1(dataGridView2, ds1, "select * from TblDanhSachKyLuat");
            cls.loadcombobox(comboBox1, "select * from TblKyLuat", 0);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
            cls.loadcombobox(comboBox3, "select * from TblTTCaNhan", 0);
            cls.loaddatagridview(dataGridView2, "select * from TblDanhSachKyLuat");    
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            cls.loadcombobox(comboBox2, "select * from TblTTCaNhan", 0);
            // cls.loadcombobox(comboBox4, "select * from TblBoPhan", 0);
            cls.loaddatagridview(dataGridView1, "select * from TblDanhSachKhenThuong");
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
           // cls.loadcombobox(comboBox3, "select * from TblTTCaNhan", 0);
           // cls.loaddatagridview(dataGridView2, "select * from TblDanhSachKyLuat");  
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            cls.loadcombobox(comboBox2, "select * from TblTTCaNhan", 0);
            // cls.loadcombobox(comboBox4, "select * from TblBoPhan", 0);
            cls.loaddatagridview(dataGridView1, "select * from TblDanhSachKhenThuong");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cls.loatextbox(textBox4, "select * from TblTTNVCoBan where MaNV ='"+comboBox2.SelectedText+"'",3);
            cls.loadtextboxchiso(textBox4, "select * from TblTTNVCoBan where MaNV=N'" + comboBox2.Text + "'", 3);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(textBox1, "select * from TblTTNVCoBan where MaNV=N'" + comboBox3.Text + "'", 3);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string insert = "insert into TblDanhSachKhenThuong(MaNV,NgayKhenThuong,MaKhenThuong,GhiChu) values(N'" + comboBox2.Text + "',N'" + dateTimePicker1.Text + "',N'" + comboBox4.Text+"',N'" +richTextBox1.Text + "')";
                    cls.thucthiketnoi(insert);
                    cls.loaddatagridview(dataGridView1, "select * from TblDanhSachKhenThuong");
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string insert = "insert into TblDanhSachKyLuat(MaNV,NgayKyLuat,MaKyLuat,GhiChu) values(N'" + comboBox3.Text + "',N'" + dateTimePicker2.Text + "',N'" + comboBox1.Text + "',N'" + richTextBox2.Text + "')";
            cls.thucthiketnoi(insert);
            //cls.loaddatagridview(dataGridView2, "select * from TblDanhSachKyLuat");
            DataSet ds1 = new DataSet();
            
            cls.loaddatagridview1(dataGridView2, ds1, "select * from TblDanhSachKyLuat");
           
        }
    }
}
