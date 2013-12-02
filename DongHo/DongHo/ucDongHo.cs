using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DongHo
{
    public partial class ucDongHo : UserControl
    {
        private int _gio;

        public int Gio
        {
            get { return _gio; }
            set
            {
                _gio = value;
                if (_gio < 0)
                {
                    _gio = 0;
                }
                lbGio.Text = _gio.ToString("00");
            }
        }
        private int _phut;

        public int Phut
        {
            get { return _phut; }
            set
            {
                _phut = value;
                if (_phut > 60)
                {
                    _phut = 60;
                }
                else if (_phut < 0)
                {
                    _phut = 0;
                }
                lbPhut.Text = _phut.ToString("00");
            }
        }
        private int _giay;

        public int Giay
        {
            get { return _giay; }
            set
            {
                _giay = value;
                if (_giay > 60)
                {
                    _giay = 60;
                }
                else if (value < 0)
                {
                    _giay = 0;
                }
                lbGiay.Text = _giay.ToString("00");
            }
        }

        public ucDongHo()
        {
            InitializeComponent();
        }

        public void StartClock()
        {
            timer1.Enabled = true;
        }

        public void StopClock()
        {
            timer1.Enabled = false;
        }

        public delegate void HenGioHandler();
        public event HenGioHandler HenGio;

        private void timer1_Tick(object sender, EventArgs e)
        {
            _giay = _giay - 1;
            if (_giay < 0)
            {
                _phut = _phut - 1;
                _giay = 59;
                if (_phut < 0)
                {
                    _gio = _gio - 1;
                    _phut = 59;
                    if (_gio < 0)
                    {
                        _gio = 0;
                        _phut = 0;
                        _giay = 0;
                        timer1.Enabled = false;
                        MessageBox.Show("Hết giờ");
                    }
                }
            }
            lbGiay.Text = Giay.ToString("00");
            lbPhut.Text = Phut.ToString("00");
            lbGio.Text = Gio.ToString("00");

        }
    }
}
