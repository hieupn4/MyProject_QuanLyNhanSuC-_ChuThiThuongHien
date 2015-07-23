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
    public partial class frmluanchuyen : Form
    {
        Clsdatabase cls = new Clsdatabase();
        DataSet ds1 = new DataSet();
        public frmluanchuyen()
        {
            InitializeComponent();
        }

        private void frmluanchuyen_Load(object sender, EventArgs e)
        {
            cls.loadcombobox(comboBox2, "select * from TblTTNVCoBan", 2);
            cls.loadcombobox(comboBox4, "select * from TblBoPhan", 0);
            cls.loaddatagridview(dataGridView1, "select * from Transfer");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(textBox4, "select * from TblTTNVCoBan where MaNV=N'" + comboBox2.Text + "'", 3);
            cls.loadtextboxchiso(textBox3, "select * from TblTTNVCoBan where MaNV=N'" + comboBox2.Text + "'", 0);
            cls.loadtextboxchiso(textBox5, "select * from TblTTNVCoBan where MaNV=N'" + comboBox2.Text + "'", 1);
            cls.loadtextboxchiso(textBox12, "select * from TblTTNVCoBan where MaNV=N'" + comboBox2.Text + "'", 11);
            cls.loadtextboxchiso(textBox13, "select * from TblTTNVCoBan where MaNV=N'" + comboBox2.Text + "'", 12);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            cls.loadcombobox(comboBox1, "select * from TblPhongBan where MaBoPhan=N'" + comboBox4.Text + "'", 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string insert = "insert into Transfer(EmployeeID,FromDepartmentID,FromLocationID,FromChucVu,ToDepartmentID,ToLocationID,ToChucVu) values(N'" + comboBox2.Text + "',N'" + textBox3.Text + "',N'" + textBox5.Text + "',N'" + textBox12.Text + "',N'" + comboBox4.Text + "',N'" + comboBox1.Text + "',N'" + textBox2.Text + "')";
                cls.thucthiketnoi(insert);
                dataGridView1.Refresh();
                cls.loaddatagridview1(dataGridView1, ds1, "select * from Transfer");
                string update = "update TblTTNVCoBan set MaBoPhan=N'" + comboBox4.Text + "',ChucDanh=N'" + textBox1.Text + "',MaPhong=N'" + comboBox1.Text + "',ChucVu=N'" + textBox2.Text + "' where MaNV=N'" + comboBox2.Text + "'";
                cls.thucthiketnoi(update);
                    
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cry_luanchyen fbc1 = new Cry_luanchyen();
            fbc1.ShowDialog();
        }
    }
}
