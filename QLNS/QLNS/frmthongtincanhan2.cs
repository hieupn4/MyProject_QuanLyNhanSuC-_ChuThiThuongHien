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
    public partial class frmthongtincanhan2 : Form
    {
        public frmthongtincanhan2()
        {
            InitializeComponent();
        }
        Clsdatabase cls = new Clsdatabase();
        private void tabPage1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
            cls.loaddatagridview(dataGridView1, "select * from TblTTCaNhan");
            cls.loadcombobox(comboBox1, "select * from TblTTNVCoBan", 2);
        }
        

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void textBox6_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!cls.kttrungkhoa(comboBox1.Text, "select MaNV from TblTTCaNhan"))
                {
                    string insert = "insert into TblTTCaNhan values(N'" + comboBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "',N'" + textBox4.Text + "',N'" + textBox5.Text + "',N'" + textBox6.Text + "',N'" + textBox7.Text + "',N'" + textBox8.Text + "',N'" + textBox9.Text + "',N'" + textBox10.Text + "',N'" + textBox11.Text + "',N'" + textBox12.Text + "',N'" + textBox13.Text + "','" + dateTimePicker1.Text + "',N'" + textBox15.Text + "',N'" + textBox16.Text + "',N'" + textBox17.Text + "')";
                    cls.thucthiketnoi(insert);
                    dataGridView1.Refresh();
                    cls.loaddatagridview(dataGridView1, "select * from TblTTCaNhan");
                }
                else MessageBox.Show("Thông tin về nhân viên này đã tồn tại");

            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không chính sác");
            }
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Enabled = false;
            int hang = e.RowIndex;
            comboBox1.Text = dataGridView1.Rows[hang].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[hang].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[hang].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[hang].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[hang].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[hang].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[hang].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[hang].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.Rows[hang].Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.Rows[hang].Cells[9].Value.ToString();
            textBox11.Text = dataGridView1.Rows[hang].Cells[10].Value.ToString();
            textBox12.Text = dataGridView1.Rows[hang].Cells[11].Value.ToString();
            //textBox13.Text = dataGridView1.Rows[hang].Cells[12].Value.ToString();
            //dateTimePicker1.Text = dataGridView1.Rows[hang].Cells[13].Value.ToString();
            //textBox15.Text = dataGridView1.Rows[hang].Cells[14].Value.ToString();
            //textBox16.Text = dataGridView1.Rows[hang].Cells[15].Value.ToString();
            textBox17.Text = dataGridView1.Rows[hang].Cells[12].Value.ToString();
        }


        private void frmthongtincanhan2_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
            cls.loaddatagridview(dataGridView1, "select * from TblTTCaNhan");
            cls.loadcombobox(comboBox1, "select * from TblTTNVCoBan", 2);
            dateTimePicker2.CustomFormat = " MM / dd / yyyy ";
            dateTimePicker3.CustomFormat = " MM / dd / yyyy ";
            dateTimePicker4.CustomFormat = " MM / dd / yyyy ";
            dateTimePicker5.CustomFormat = " MM / dd / yyyy ";
            DataSet ds1 = new DataSet();
            cls.loadcombobox(comboBox2, "select * from TblBoPhan", 0);
            cls.loadcombobox(comboBox3, "select * from TblPhongBan", 1);
            cls.loaddatagridview1(dataGridView2,ds1, "select * from TblTTNVCoBan");
            cls.loadcombobox(comboBox6, "select * from TblBoPhan", 0);
            DataSet ds2 = new DataSet();
            cls.loaddatagridview1(dataGridView3, ds2, "select MaNV,HoTen from TblTTNVCoBan");
            DataSet ds3 = new DataSet();
            cls.loaddatagridview1(dataGridView4, ds3, "select MaBoPhan,MaPhong,TenPhong from TblPhongBan");
            DataSet ds4 = new DataSet();
            cls.loaddatagridview1(dataGridView5, ds4, "select * from TblTTNVCoBan");
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Cry_TTCN_Employee xps = new Cry_TTCN_Employee();
            xps.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            string update = "update TblTTCaNhan set Manv=N'" + comboBox1.Text + "',Noisinh=N'" + textBox2.Text + "',NguyenQuan=N'" + textBox3.Text + "',DCthuongtru=N'" + textBox4.Text + "',DCtamtru='" + textBox5.Text + "',SDT=N'" + textBox6.Text + "',DanToc=N'" + textBox7.Text + "',TonGiao=N'" + textBox8.Text + "',QuocTich='" + textBox9.Text + "',TiengNN=N'" + textBox10.Text + "',TrinhDoNN=N'" + textBox11.Text + "',HocVan=N'" + textBox12.Text + "',GhiChu=N'" + textBox17.Text + "' where MaNV=N'" + comboBox1.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView1, "select * from TblTTCaNhan");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string delete = "delete from TblTTCaNhan where MaNV=N'" + comboBox1.Text + "'";     
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(delete);
                    cls.loaddatagridview(dataGridView1, "select * from TblTTCaNhan");
                }
            }
            catch
            {
                MessageBox.Show("không xóa được");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("không xóa được");
            dateTimePicker2.CustomFormat = " MM / dd / yyyy ";
            dateTimePicker3.CustomFormat = " MM / dd / yyyy ";
            dateTimePicker4.CustomFormat = " MM / dd / yyyy ";
            dateTimePicker5.CustomFormat = " MM / dd / yyyy ";
            cls.loadcombobox(comboBox2, "select * from TblBoPhan", 0);
            cls.loadcombobox(comboBox3, "select * from TblPhongBan", 1);
            cls.loaddatagridview(dataGridView2, "select * from TblTTNVCoBan");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string delete = "delete from TblTTNVCoBan where MaNV=N'" + textBox27.Text + "'";
           /* string delete1 = "delete from TblTTCaNhan where MaNV=N'" + textBox27.Text + "'";
            string delete2 = "delete from TblChamCong where MaNV=N'" + textBox27.Text + "'";
            string delete3 = "delete from TblBangCongThuViec where MaNV=N'" + textBox27.Text + "'";
            string delete4 = "delete from TblBangLuong where MaNV=N'" + textBox27.Text + "'";
            string delete5 = "delete from TblDanhSachKhenThuong where MaNV=N'" + textBox27.Text + "'";
            string delete6 = "delete from TblDanhSachKyLuat where MaNV=N'" + textBox27.Text + "'";
            string delete7 = "delete from TblHoSoThuViec where MaNV=N'" + textBox27.Text + "'";
            string delete8 = "delete from TblSoBH where MaNV=N'" + textBox27.Text + "'";
            string delete9 = "delete from TblTangLuong where MaNV=N'" + textBox27.Text + "'";
            string delete10 = "delete from TblThaiSan where MaNV=N'" + textBox27.Text + "'";
            string delete11 = "delete from TblChamCong where EmployeeID=N'" + textBox27.Text + "'"; */
            if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cls.thucthiketnoi(delete);
                cls.loaddatagridview(dataGridView2, "select * from TblTTNVCoBan");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                textBox27.Enabled = false;
                int hang = e.RowIndex;
                comboBox2.Text = dataGridView2.Rows[hang].Cells[1].Value.ToString();
                comboBox3.Text = dataGridView2.Rows[hang].Cells[0].Value.ToString();
                comboBox4.Text = dataGridView2.Rows[hang].Cells[6].Value.ToString();
                dateTimePicker2.Text = dataGridView2.Rows[hang].Cells[5].Value.ToString();
                dateTimePicker3.Text = dataGridView2.Rows[hang].Cells[9].Value.ToString();
                dateTimePicker4.Text = dataGridView2.Rows[hang].Cells[15].Value.ToString();
                dateTimePicker5.Text = dataGridView2.Rows[hang].Cells[16].Value.ToString();
                textBox27.Text = dataGridView2.Rows[hang].Cells[2].Value.ToString();
                textBox26.Text = dataGridView2.Rows[hang].Cells[3].Value.ToString();
                textBox25.Text = dataGridView2.Rows[hang].Cells[4].Value.ToString();
                textBox24.Text = dataGridView2.Rows[hang].Cells[7].Value.ToString();
                textBox23.Text = dataGridView2.Rows[hang].Cells[8].Value.ToString();
                textBox22.Text = dataGridView2.Rows[hang].Cells[10].Value.ToString();
                textBox21.Text = dataGridView2.Rows[hang].Cells[11].Value.ToString();
                textBox20.Text = dataGridView2.Rows[hang].Cells[12].Value.ToString();
                textBox14.Text = dataGridView2.Rows[hang].Cells[13].Value.ToString();
                textBox1.Text = dataGridView2.Rows[hang].Cells[14].Value.ToString();
                textBox18.Text = dataGridView2.Rows[hang].Cells[17].Value.ToString();
                textBox19.Text = dataGridView2.Rows[hang].Cells[18].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //try
            //{
                string update = "update TblTTNVCoBan set Hoten=N'" + textBox26.Text + "',BiDanh=N'" + textBox25.Text + "',NgaySinh=N'" + dateTimePicker5.Text + "',GioiTinh=N'" + comboBox4.Text + "',TTHonNhan='" + textBox24.Text + "',CMTND=N'" + textBox23.Text + "',NgayCap=N'" + dateTimePicker2.Text + "',NoiCap=N'" + textBox22.Text + "',ChucVu='" + textBox21.Text + "',ChucDanh=N'" + textBox20.Text + "',LoaiHD=N'" + textBox14.Text + "',ThoiGian=N'" + textBox1.Text + "',NgayKy=N'" + dateTimePicker3.Text + "',NgayHetHan=N'" + dateTimePicker4.Text + "',Anh='" + textBox18.Text + "',GhiChu='" + textBox19.Text + "' Where MaNV=N'" + textBox27.Text + "'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview(dataGridView2, "select * from TblTTNVCoBan");
           /* }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            } */
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
           

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.Items.Clear();
            String x = comboBox6.Text;
            cls.loadcombobox(comboBox5, "select * from TblPhongBan where MaBoPhan ='" + x + "'", 1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if ((comboBox5.Text.Equals("")) || (comboBox6.Text.Equals("")) || (textBox39.Text.Equals("")))
                MessageBox.Show("tồn tại trường chưa nhập Hiên kìa !!?", "Hiền ơi có vấn đề!!");
            else
            {
                try
                {
                    if (!cls.kttrungkhoa(textBox39.Text, "select MaNV from TblTTCaNhan"))
                    {
                        string insert1 = "insert into TblTTCaNhan(MaNV) values(N'" + textBox39.Text + "')";
                        string insert2 = "insert into TblTTNVCoBan(MaBoPhan,MaPhong,MaNV,HoTen,NgaySinh,GioiTinh) values(N'"+ comboBox6.Text +"',N'"+ comboBox5.Text + "',N'"+textBox39.Text +"',N'"+textBox38.Text+"',N'"+dateTimePicker9.Text+"',N'"+comboBox7.Text +"')";
                        string insert3 = "insert into TblBangLuong values(N'" + textBox39.Text + "',N'" + textBox29.Text + "',N'" + textBox28.Text + "',N'" + "')";
                        cls.thucthiketnoi(insert1);
                        cls.thucthiketnoi(insert2);
                        cls.thucthiketnoi(insert3);
               
                        //cls.loaddatagridview(dataGridView1, "select * from TblTTCaNhan");
                    }
                    else MessageBox.Show("Thông tin về nhân viên này đã tồn tại");

                }
                catch
                {
                    MessageBox.Show("Dữ liệu đầu vào không chính sác");
                }
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox29.Clear();
            textBox28.Clear();
            textBox39.Clear();
            textBox38.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Cry_TTCN_Employee xps = new Cry_TTCN_Employee();
            xps.Show();
        }

       }

        
    }
