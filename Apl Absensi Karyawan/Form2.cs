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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Nama: " + namaBox.Text;
            label2.Text = "Jabatan : " + jbtnBox.Text;
            label3.Text = "Divisi : " + dvsBox.Text;
            label4.Text = "ID Karyawan : " + IdBox.Text;
            label5.Text = "Status Kehadiran : " + sttsBox.Text;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            label1.Text = "Nama: " + namaBox.Text;
            label2.Text = "Jabatan : " + jbtnBox.Text;
            label3.Text = "Divisi : " + dvsBox.Text;
            label4.Text = "ID Karyawan : " + IdBox.Text;
            label5.Text = "Status Kehadiran : " + sttsBox.Text;

            MessageBox.Show("" + namaBox.Text + " absensimu tersimpan!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            namaBox.Text = "";
            jbtnBox.Text = "";
            dvsBox.Text = "";
            IdBox.Text = "";
            tglPicker.Text = "";
            sttsBox.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";

            MessageBox.Show("Data absensimu terhapus");
        }
    }
}
