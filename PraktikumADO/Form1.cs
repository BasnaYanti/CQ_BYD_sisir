using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Menambahkan namespace untuk SQL Server

namespace PraktikumADO
{
    public partial class Form1 : Form
    {
        // Mendeklarasikan variabel koneksi dan command secara global
        SqlConnection conn;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        // Method untuk konfigurasi koneksi ke database
        private void Koneksi()
        {
            conn = new SqlConnection(
                "Data Source=LAPTOP-UJA021TQ\\BASNAYANTI;Initial Catalog=DBAkademikADO;Integrated Security=True"
            );
        }

        // PRAKTIKUM 1: Membuka Koneksi (Implementasi Dasar)
        private void button1_Click(object sender, EventArgs e)
        {
            Koneksi();
            conn.Open();
            MessageBox.Show("Koneksi ke database berhasil");
            conn.Close();
        }
    }
}