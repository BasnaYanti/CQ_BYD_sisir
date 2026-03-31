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

        // PRAKTIKUM 1: Membuka Koneksi (Dengan Error Handling)
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();
                MessageBox.Show("Koneksi ke database berhasil");
                conn.Close();
            }
            catch (Exception ex)
            {
                // Menampilkan pesan jika terjadi kesalahan koneksi
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // PRAKTIKUM 2: Menghitung Jumlah Mahasiswa (ExecuteScalar)
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                // Query untuk menghitung jumlah baris di tabel Mahasiswa
                string query = "SELECT COUNT(*) FROM Mahasiswa";
                cmd = new SqlCommand(query, conn);

                // ExecuteScalar mengambil satu nilai dari baris pertama kolom pertama
                int jumlah = (int)cmd.ExecuteScalar();

                // Menampilkan hasil ke TextBox txtHasil
                txtHasil.Text = jumlah.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // PRAKTIKUM 3: Menghitung Jumlah Mata Kuliah (ExecuteScalar)
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                // Query untuk menghitung jumlah baris di tabel MataKuliah
                string query = "SELECT COUNT(*) FROM MataKuliah";
                cmd = new SqlCommand(query, conn);

                int jumlah = (int)cmd.ExecuteScalar();
                txtHasil.Text = jumlah.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}