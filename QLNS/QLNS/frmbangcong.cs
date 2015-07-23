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
    public partial class frmbangcong : Form
    {
        Clsdatabase cls = new Clsdatabase();
        TextBox giocong = new TextBox();
        TextBox ngaycong = new TextBox();
        public frmbangcong()
        {
            InitializeComponent();
        }
        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        DataSet ds4 = new DataSet();
        DataSet ds5 = new DataSet();
        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void frmbangcong_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            //DateTime dt1, dt2;
            //dt1 = new DateTime(2009, 5, 10);
            //dt2 = new DateTime(2009, 10, 10);
            txt12.Text = "0";

           // cls.loadcombobox(cb1, "select MaNV from TblHoSoThuViec", 0);
            cls.loadcombobox(cb2, "select MaNV from TblTTNVCoBan", 0);
            cls.loadtextbox(txt10, "select LCB from TblBangLuong where MaNV ='" + cb2.Text + "'");
            cls.loadtextbox(txt11, "select PCChucVu from TblBangLuong where MaNV ='" + cb2.Text + "'");
           // cls.loadcombobox(cb3, "select MaNV from TblTTNVCoBan", 0);
           // cls.loadcombobox(cb4, "select MaNV from TblTTNVCoBan", 0);
           // cls.loadcombobox(cb5, "select MaNV from TblTTNVCoBan", 0);
           // cls.loaddatagridview1(dataGridView1,ds1, "select * from TblBangCongThuViec");
            cls.loaddatagridview1(dataGridView2,ds2, "select * from TblChamCong");
           // cls.loaddatagridview1(dataGridView3,ds3, "select * from TblCongKhoiSanXuat");
           // cls.loaddatagridview1(dataGridView4,ds4, "select * from TblCongKhoiVanChuyen");
           // cls.loaddatagridview1(dataGridView5,ds5, "select * from TblCongKhoiVanPHong");
        }

        private void button7_Click(object sender, EventArgs e)
        {
           /* foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            foreach (Control ctr in this.groupBox4.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
         
        }

        private void button25_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string update = "update TblChamCong set PhuCapKhac=" + txt12.Text +",SoNgayCongThang=" + txt15.Text + ",SoNgayNghi=" + txt16.Text + ",SoGioLamThem=" + txt17.Text + ",GhiChu='" + txt18.Text + "' where MaNV=N'" + cb2.Text + "' AND Thang=N'"+ txt13.Text+"' AND Nam =N'"+txt14.Text +"'";
                cls.thucthiketnoi(update);
                cls.loaddatagridview1(dataGridView2, ds2, "select * from TblChamCong");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            } 
        }

        private void button18_Click(object sender, EventArgs e)
        {
           
        }

        private void button24_Click(object sender, EventArgs e)
        {
            
        }

        private void button30_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            try
            {
                string delete = "delete from TblChamCong where MaNV=N'" + cb2.Text + "'";
                if (MessageBox.Show("Bạn có muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls.thucthiketnoi(delete);
                    cls.loaddatagridview1(dataGridView2, ds2, "select * from TblChamCong");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
           

        }

        private void button22_Click(object sender, EventArgs e)
        {
            
        }

        private void button28_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* cls.loadtextboxchiso(txt10, "select * from TblChamCong where MaNV='" + cb2.Text + "'", 1);
            cls.loadtextboxchiso(txt11, "select * from TblChamCong where MaNV='" + cb2.Text + "'", 2);
            cls.loadtextboxchiso(txt12, "select * from TblChamCong where MaNV='" + cb2.Text + "'", 3);
            cls.loadtextboxchiso(txt13, "select * from TblChamCong where MaNV='" + cb2.Text + "'", 4);
            cls.loadtextboxchiso(txt14, "select * from TblChamCong where MaNV='" + cb2.Text + "'", 5);
            cls.loadtextboxchiso(txt15, "select * from TblChamCong where MaNV='" + cb2.Text + "'", 6);
            cls.loadtextboxchiso(txt16, "select * from TblChamCong where MaNV='" + cb2.Text + "'", 7);
            cls.loadtextboxchiso(txt17, "select * from TblChamCong where MaNV='" + cb2.Text + "'", 8);
            cls.loadtextboxchiso(txt18, "select * from TblChamCong where MaNV='" + cb2.Text + "'", 9); */
            cls.loadtextbox(txt10, "select LCB from TblBangLuong where MaNV='" + cb2.Text + "'");
            cls.loadtextbox(txt11, "select PCChucVu from TblBangLuong where MaNV='" + cb2.Text + "'");
            txt13.Enabled = true;
            txt14.Enabled = true;
            groupBox1.Hide();
        }

        private void cb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void cb4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cb5_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Show();
            int i = e.RowIndex;
            cb2.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
            txt10.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            txt11.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            txt12.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            txt13.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            txt14.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            txt15.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
            txt16.Text = dataGridView2.Rows[i].Cells[7].Value.ToString();
            txt17.Text = dataGridView2.Rows[i].Cells[8].Value.ToString();
            txt18.Text = dataGridView2.Rows[i].Cells[9].Value.ToString();
            giocong.Text = dataGridView2.Rows[i].Cells[10].Value.ToString();
            
            int x = int.Parse(txt12.Text) + ((int.Parse(txt10.Text) + int.Parse(txt11.Text)) / 26) * int.Parse(txt15.Text) + int.Parse(txt17.Text) * int.Parse(giocong.Text);
           // MessageBox.Show(giocong.Text);
            textBox1.Text = Convert.ToString(x);

            txt13.Enabled = false;
            txt14.Enabled = false;
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt11_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt19_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt21_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt23_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt24_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt25_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt28_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt29_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt30_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt31_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt32_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt33_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt34_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt35_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
          /*  try
            {

                string insert = "insert into TblBangCongThuViec values(N'" + txt1.Text + "',N'" + txt2.Text + "',N'" + cb1.Text + "',N'" + txt3.Text + "',N'" + txt4.Text + "',N'" + txt5.Text + "',N'" + txt6.Text + "',N'" + txt7.Text + "',N'" + txt8.Text + "',N'" + txt9.Text + "')";
                if (!cls.kttrungkhoa(cb1.Text, "select MaNV from TblBangCongThuViec"))
                {
                    if (cb1.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridView1.Refresh();
                        cls.loaddatagridview1(dataGridView1, ds1, "select * from TblBangCongThuViec");

                    }
                    else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
                }
                else
                    MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            } */
        }

        private void button17_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            try
            {
                
                cls.loadtextboxchiso(giocong, "select * from TblgiatriCong", 0);
                cls.loadtextboxchiso(ngaycong, "select * from TblgiatriCong", 1);
                //MessageBox.Show(giocong.Text + ngaycong.Text);

                string insert = "insert into TblChamCong values(N'" + cb2.Text + "'," + txt10.Text + ",N'" + txt11.Text + "'," + txt12.Text + ",N'" + txt13.Text + "',N'" + txt14.Text + "'," + txt15.Text + "," + txt16.Text + "," + txt17.Text + ",N'" + txt18.Text + "',N'"+ giocong.Text + "',N'"+ngaycong.Text + "')";
                if (!((cls.kttrungkhoa(cb2.Text, "select MaNV from TblChamCong")) && (cls.kttrungkhoa(txt13.Text, "select Thang from TblChamCong")) && (cls.kttrungkhoa(txt14.Text, "select Nam from TblChamCong"))))
                {
                    if (cb2.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridView2.Refresh();
                        
                        cls.loaddatagridview1(dataGridView2, ds2, "select * from TblChamCong");
                       
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
                }
                else
                    MessageBox.Show("Đã Chấm Công", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Đã Chấm Công");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
         /*   try
            {

                string insert = "insert into TblCongKhoiSanXuat values(N'" + cb3.Text + "',N'" + txt19.Text + "',N'" + txt20.Text + "',N'" + txt21.Text + "',N'" + txt22.Text + "',N'" + txt23.Text + "',N'" + txt24.Text + "',N'" + txt25.Text + "',N'" + txt26.Text + "',N'" + txt27.Text + "')";
                if (!cls.kttrungkhoa(cb3.Text, "select MaNV from TblCongKhoiSanXuat"))
                {
                    if (cb3.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridView1.Refresh();
                        
                        cls.loaddatagridview1(dataGridView3, ds3, "select * from TblCongKhoiSanXuat");
                       
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
                }
                else
                    MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            } */
        }

        private void button29_Click(object sender, EventArgs e)
        {
          /*  try
            {

                string insert = "insert into TblCongKhoiVanChuyen values(N'" + cb4.Text + "',N'" + txt28.Text + "',N'" + txt29.Text + "',N'" + txt30.Text + "',N'" + txt31.Text + "',N'" + txt32.Text + "',N'" + txt33.Text + "',N'" + txt34.Text + "',N'" + txt35.Text + "',N'" + txt36.Text + "')";
                if (!cls.kttrungkhoa(cb4.Text, "select MaNV from TblCongKhoiVanChuyen"))
                {
                    if (cb4.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridView1.Refresh();
                     
                        cls.loaddatagridview1(dataGridView4, ds4, "select * from TblCongKhoiVanChuyen");
                        
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
                }
                else
                    MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            } */
        }

        private void button5_Click(object sender, EventArgs e)
        {
         /*   try
            {

                string insert = "insert into TblCongKhoiVanPHong values(N'" + cb5.Text + "',N'" + txt37.Text + "',N'" + txt38.Text + "',N'" + txt39.Text + "',N'" + txt40.Text + "',N'" + txt41.Text + "',N'" + txt42.Text + "',N'" + txt43.Text + "',N'" + txt44.Text + "',N'" + txt45.Text + "')";
                if (!cls.kttrungkhoa(cb5.Text, "select MaNV from TblCongKhoiVanPHong"))
                {
                    if (cb5.Text != "")
                    {
                        cls.thucthiketnoi(insert);
                        dataGridView1.Refresh();
                        cls.loaddatagridview1(dataGridView5, ds5, "select * from TblCongKhoiVanPHong");
                    }
                    else MessageBox.Show("Bạn chưa nhập Mã nhân viên");
                }
                else
                    MessageBox.Show("Mã nhân viên này đã tồn tại", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            } */
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cry_chamcong dpp = new Cry_chamcong();
            dpp.Show();
        }   
    }
}
