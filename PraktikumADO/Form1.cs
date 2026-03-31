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
    }
}