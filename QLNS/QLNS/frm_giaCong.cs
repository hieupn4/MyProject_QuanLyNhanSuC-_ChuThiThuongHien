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
    public partial class frm_giaCong : Form
    {
        Clsdatabase cls = new Clsdatabase();
        public frm_giaCong()
        {
            InitializeComponent();
        }

        private void frm_giaCong_Load(object sender, EventArgs e)
        {
            cls.loadtextboxchiso(textBox1, "select * from TblgiatriCong ", 0);
            cls.loadtextboxchiso(textBox2, "select * from TblgiatriCong ", 1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String day = DateTime.Now.Day.ToString();
                String month = DateTime.Now.Month.ToString();
                String year = DateTime.Now.Year.ToString();
                String x = month + "/" + day + "/" + year;
                string insert = "insert into TblChangegiatriCong(congtheogiocu,congtheogiomoi,congtheongaycu,congtheongaymoi,ngaythaydoi) values(N'" + textBox1.Text + "',N'" + textBox4.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "',N'" + x + "')";
                string update = "update TblgiatriCong set congtheogio=N'" + textBox4.Text + "',congtheongay =N'" + textBox3.Text + "'";
                cls.thucthiketnoi(insert);
                cls.thucthiketnoi(update);
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }
    }
}
