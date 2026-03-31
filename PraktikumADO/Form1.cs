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
                txtHasill.Text = jumlah.ToString();

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
                txtHasill.Text = jumlah.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // PRAKTIKUM 4: Update Alamat Mahasiswa (ExecuteNonQuery)
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                // Query untuk mengubah alamat mahasiswa berdasarkan NIM tertentu
                string query = "UPDATE Mahasiswa SET Alamat='Yogyakarta' WHERE NIM='23110100001'";
                cmd = new SqlCommand(query, conn);

                // ExecuteNonQuery mengembalikan jumlah baris yang terpengaruh/terupdate
                int hasil = cmd.ExecuteNonQuery();

                // MENAMBAHKAN NOTIFIKASI HASIL UPDATE (Langkah Commit 10)
                MessageBox.Show("Jumlah baris terpengaruh : " + hasil);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // LATIHAN 1: Menghitung Jumlah Dosen (ExecuteScalar)
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string query = "SELECT COUNT(*) FROM Dosen";
                cmd = new SqlCommand(query, conn);

                int jumlah = (int)cmd.ExecuteScalar();
                txtHasill.Text = jumlah.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // LATIHAN 2: Update SKS Mata Kuliah (ExecuteNonQuery)
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                // Query untuk memperbarui SKS mata kuliah tertentu
                string query = "UPDATE MataKuliah SET SKS = 4 WHERE KodeMK = 'IF210101'";
                cmd = new SqlCommand(query, conn);

                int hasil = cmd.ExecuteNonQuery();
                MessageBox.Show("Jumlah data terupdate: " + hasil);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}