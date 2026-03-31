using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace PraktikumADO
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        private object txtHasil;

        private void Koneksi()
        {
            conn = new SqlConnection(
                "Data Source =LAPTOP-UJA021TQ\\BASNAYANTI;Initial Catalog=DBAkademikADO;Integrated Security=True"
                );
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

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
                MessageBox.Show(ex.Message);
            }
        }
    }

}

