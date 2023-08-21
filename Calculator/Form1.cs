using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekranTemizlenecekMi;
        private int _ilkSayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void rakam1button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                screenLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (screenLabel.Text =="0") screenLabel.Text = "";
            screenLabel.Text += "1";
        }

        private void rakam2button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                screenLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "2";
        }

        private void rakam3button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                screenLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "3";
        }

        private void rakam4button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                screenLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "4";
        }

        private void rakam5button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                screenLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "5";
        }

        private void rakam6button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                screenLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "6";
        }

        private void rakam7button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                screenLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "7";
        }

        private void rakam8button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                screenLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "8";
        }

        private void rakam9button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                screenLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "9";
        }

        private void rakam0button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
               screenLabel.Text = "";
               _ekranTemizlenecekMi = false;
            }
            
            if (screenLabel.Text == "0") screenLabel.Text = "";
            screenLabel.Text += "0";
        }

        private void artıbutton_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(screenLabel.Text);

        }

        private void eksibutton_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(screenLabel.Text);
        }

        private void çarpmabutton_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(screenLabel.Text);
        }

        private void bölmebutton_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilkSayi = Convert.ToInt32(screenLabel.Text);
        }

        private void esittirbutton_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(screenLabel.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi; break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi; break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi; break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi; break;
                default:
                    sonuc = 0; break;
            }
            screenLabel.Text = Convert.ToString(sonuc);
           
        }

        private void temizlebutton_Click(object sender, EventArgs e)
        {
            screenLabel.Text = "0";

        }
    }
}
