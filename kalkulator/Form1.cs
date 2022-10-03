using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            hasil.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka Harus Diisi Terlebih Dahulu!");
            }
            else { 
            int a, b, hasil;
            a = int.Parse(this.textBox1.Text);
            b = int.Parse(this.textBox2.Text);
            hasil = a / b;
            this.hasil.Text = hasil.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka Harus Diisi Terlebih Dahulu!");
            }
            else { 
            int a, b, hasil;
            a = int.Parse(this.textBox1.Text);
            b = int.Parse(this.textBox2.Text);
            hasil = a % b;
            this.hasil.Text = hasil.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka Harus Diisi Terlebih Dahulu!");
            }
            else { 
            int a, b, hasil;
            a = int.Parse(this.textBox1.Text);
            b = int.Parse(this.textBox2.Text);
            hasil = a + b;
            this.hasil.Text = hasil.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka Harus Diisi Terlebih Dahulu!");
            }
            else { 
            int a, b, hasil;
            a = int.Parse(this.textBox1.Text);
            b = int.Parse(this.textBox2.Text);
            hasil = a - b;
            this.hasil.Text = hasil.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka Harus Diisi Terlebih Dahulu!");
            }
            else { 
            int a, b, hasil;
            a = int.Parse(this.textBox1.Text);
            b = int.Parse(this.textBox2.Text);
            hasil = a * b;
            this.hasil.Text = hasil.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            hasil.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int satu = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int dua = 2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int tiga = 3;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int empat = 4;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int lima = 5;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int enam = 6;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int tujuh = 7;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int delapan = 8;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int sembilan = 9;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int nol = 0;
        }
    }
}
