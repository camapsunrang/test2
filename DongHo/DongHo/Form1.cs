using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DongHo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucDongHo1.Giay = 0;
            ucDongHo1.Phut = 0;
            ucDongHo1.Gio = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtGio.Text != "" && txtPhut.Text != "" && txtGiay.Text != "")
            {
                ucDongHo1.Giay = int.Parse(txtGiay.Text);
                ucDongHo1.Phut = int.Parse(txtPhut.Text);
                ucDongHo1.Gio = int.Parse(txtGio.Text);
                if (ucDongHo1.Gio > 99)
                    ucDongHo1.Gio = 99;
            }
            else
            {
                MessageBox.Show("Xin nhập đủ");
            }
            
        }

        private void txtGio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPhut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtGiay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ucDongHo1.StartClock();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ucDongHo1.StopClock();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ucDongHo1.StopClock();
            ucDongHo1.Giay = 0;
            ucDongHo1.Phut = 0;
            ucDongHo1.Gio = 0;
        }
    }
}
