using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apl_Absensi_Karyawan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Karyawan" && textBox2.Text == "12345")
            {
                new Form2().Show();
                this.Hide();
            }
            else if (textBox1.Text == "Admin" && textBox2.Text == "678910")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nama pengguna / kata sandi salah");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Karyawan" && textBox2.Text == "12345")
            {
                new Form2().Show();
                this.Hide();
            }
            else if (textBox1.Text == "Admin" && textBox2.Text == "678910")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nama pengguna / kata sandi salah");
            }
        }
    }
}
