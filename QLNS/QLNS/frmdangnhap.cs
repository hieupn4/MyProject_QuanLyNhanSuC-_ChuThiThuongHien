using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNS
{
    public partial class frmdangnhap : Form
    {

        Clsdatabase cls = new Clsdatabase();

        public frmdangnhap()
        {
            InitializeComponent();
            textBox1.Text = "thuonghien";
            textBox2.Text = "123";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show( cls.thu(textBox2.Text, "select pass from tbuser").ToString());
            if ((cls.kt(textBox1.Text, "select * from tbluser", 0) == true)&&(cls.kt(textBox2.Text, "select * from tbluser", 1) == true))
            {
                this.Hide();
                FrmMain fm = new FrmMain();
                fm.k = 4;
                fm.truyen();
                MessageBox.Show("Bạn đã đăng nhập thành công");
                fm.ShowDialog();               

            }
            else
                MessageBox.Show("Tên đăng nhập hoặc Mật khẩu không đúng ", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmdangki d = new frmdangki();
            d.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
