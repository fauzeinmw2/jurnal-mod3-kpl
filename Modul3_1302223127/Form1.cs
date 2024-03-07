using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3_1302223127
{
    public partial class Form1 : Form
    {
        public string angka = "";
        public int hasil = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAngka1_Click(object sender, EventArgs e)
        {
            if (labelHasil.Text == "0")
            {
                labelHasil.Text = "1";
            }
            else
            {
                labelHasil.Text = labelHasil.Text + "1";
            }
            angka = angka + "1";
        }

        private void btnAngka2_Click(object sender, EventArgs e)
        {
            if (labelHasil.Text == "0")
            {
                labelHasil.Text = "2";
            }
            else
            {
                labelHasil.Text = labelHasil.Text + "2";
            }
            angka = angka + "2";
        }

        private void btnAngka3_Click(object sender, EventArgs e)
        {
            if (labelHasil.Text == "0")
            {
                labelHasil.Text = "3";
            }
            else
            {
                labelHasil.Text = labelHasil.Text + "3";
            }
            angka = angka + "3";
        }

        private void btnAngka4_Click(object sender, EventArgs e)
        {
            if (labelHasil.Text == "0")
            {
                labelHasil.Text = "4";
            }
            else
            {
                labelHasil.Text = labelHasil.Text + "4";
            }
            angka = angka + "4";
        }

        private void btnAngka5_Click(object sender, EventArgs e)
        {
            if (labelHasil.Text == "0")
            {
                labelHasil.Text = "5";
            }
            else
            {
                labelHasil.Text = labelHasil.Text + "5";
            }
            angka = angka + "5";
        }

        private void btnAngka6_Click(object sender, EventArgs e)
        {
            if (labelHasil.Text == "0")
            {
                labelHasil.Text = "6";
            }
            else
            {
                labelHasil.Text = labelHasil.Text + "6";
            }
            angka = angka + "6";
        }

        private void btnAngka7_Click(object sender, EventArgs e)
        {
            if (labelHasil.Text == "0")
            {
                labelHasil.Text = "7";
            }
            else
            {
                labelHasil.Text = labelHasil.Text + "7";
            }
            angka = angka + "7";
        }

        private void btnAngka8_Click(object sender, EventArgs e)
        {
            if (labelHasil.Text == "0")
            {
                labelHasil.Text = "8";
            }
            else
            {
                labelHasil.Text = labelHasil.Text + "8";
            }
            angka = angka + "8";
        }

        private void btnAngka9_Click(object sender, EventArgs e)
        {
            if (labelHasil.Text == "0")
            {
                labelHasil.Text = "9";
            }
            else
            {
                labelHasil.Text = labelHasil.Text + "9";
            }
            angka = angka + "9";
        }

        private void btnAngka0_Click(object sender, EventArgs e)
        {
            if (labelHasil.Text != "0")
            {
                labelHasil.Text = labelHasil.Text + "0";
                angka = angka + "0";
            }
            
        }

        private void btnPenjumlahan_Click(object sender, EventArgs e)
        {
            hasil += int.Parse(angka);
            labelHasil.Text = labelHasil.Text + " + ";
            angka = "";
        }

        private void btnSamaDengan_Click(object sender, EventArgs e)
        {
            hasil += int.Parse(angka);
            labelHasil.Text = labelHasil.Text + " = " + hasil.ToString();
        }
    }
}
