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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmdangnhap f1 = new frmdangnhap();
            f1.ShowDialog();
            this.Close();  
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmdangki d = new frmdangki();
            d.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // frmcoban f2 = new frmcoban();
           // f2.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // frmthongtincanhan f3 = new frmthongtincanhan();
           // f3.ShowDialog();
        }
        
        public int k = 1;
        public void truyen()
        {
            
            if (k == 4)
            {
                menuItem2.Enabled = true;
                menuItem3.Enabled = true;
                menuItem14.Enabled = true;
                groupBox1.Enabled = true;
                groupBox5.Enabled = true;
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

            
          
            //axWindowsMediaPlayer1.Visible = false;
            //axWindowsMediaPlayer1.URL = "nhac nen.mp3";
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            frmdangki dk = new frmdangki();
            dk.ShowDialog();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
             this.Hide();
            frmdangnhap f1 = new frmdangnhap();
            f1.ShowDialog();
            this.Close();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //frmcoban fc = new frmcoban();
            //fc.ShowDialog();
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmthongtincanhan2 ft = new frmthongtincanhan2();
            ft.ShowDialog();
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            frmdoimatkhau fdm = new frmdoimatkhau();
            fdm.ShowDialog();
        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            frmchedo fcc = new frmchedo();
            fcc.ShowDialog();
        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
            frmluong rfl = new frmluong();
            rfl.ShowDialog();
        }

        private void menuItem17_Click(object sender, EventArgs e)
        {
            frmhosothuviec fhtv = new frmhosothuviec();
            fhtv.ShowDialog();
        }

        private void menuItem15_Click(object sender, EventArgs e)
        {
            frmphongban fpb = new frmphongban();
            fpb.ShowDialog();
        }

        private void menuItem16_Click(object sender, EventArgs e)
        {
            frmbophan frb = new frmbophan();
            frb.ShowDialog();
        }

        private void menuItem18_Click(object sender, EventArgs e)
        {
            frmbangcong fbc = new frmbangcong();
            fbc.ShowDialog();
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            //frmcoban fcb = new frmcoban();
            //fcb.ShowDialog();
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            //frmthongtincanhan ftcn = new frmthongtincanhan();
            //ftcn.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmtimkiem ftk = new frmtimkiem();
            ftk.ShowDialog();
        }

        private void menuItem11_Click(object sender, EventArgs e)
        {
            frmtimkiem ftk = new frmtimkiem();
            ftk.ShowDialog();
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmchedo fcd = new frmchedo();
            fcd.ShowDialog();
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmluong fl = new frmluong();
            fl.ShowDialog();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        

        private void menuItem12_Click(object sender, EventArgs e)
        {

        }

        private void menuItem19_Click(object sender, EventArgs e)
        {
            frmbaocao fbc = new frmbaocao();
            fbc.ShowDialog();
        }

        private void menuItem20_Click(object sender, EventArgs e)
        {
            fRMBCphongban fbc1 = new fRMBCphongban();
            fbc1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuItem21_Click(object sender, EventArgs e)
        {
            frmluanchuyen rfl = new frmluanchuyen();
            rfl.ShowDialog();
        }

        private void menuItem22_Click(object sender, EventArgs e)
        {
            frmtuybien tb = new frmtuybien();
            tb.ShowDialog();
        }

        private void menuItem23_Click(object sender, EventArgs e)
        {
            frmKhenThuongKyLuat fkh = new frmKhenThuongKyLuat();
            fkh.ShowDialog();
        }

        private void menuItem7_Click_1(object sender, EventArgs e)
        {
            frm_giaCong xqs = new frm_giaCong();
            xqs.ShowDialog();
        }

    }
}
