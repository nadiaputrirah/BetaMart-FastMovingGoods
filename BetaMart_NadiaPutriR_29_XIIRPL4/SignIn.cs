using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaMart_NadiaPutriR_29_XIIRPL4
{
    public partial class SignIn : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ASUS\source\repos\BetaMart_NadiaPutriR_29_XIIRPL4\BetaMart_NadiaPutriR_29_XIIRPL4\DB_BetaMart_NadiaPutriR.accdb");
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            connection.Open();
            //perintah query
            string connect = "select count (*) From TB_AdminBetaMart where username='" + boxName.Text + "' and password='" + boxPassword.Text + "'";
            // membaca isi tabel database
            OleDbDataAdapter da = new OleDbDataAdapter(connect, connection);

            //datatable untuk menampung data kesemua tabel
            DataTable dtable = new DataTable();
            da.Fill(dtable);

            if (dtable.Rows[0][0].ToString() == "1")
            {
                //data berhasil ditemukan
                MessageBox.Show("Selamat Anda Berhasil");

                Products produk = new Products();
                produk.Show();
            }
            else
            {
                //data tidak berhasil ditemukan
                MessageBox.Show("Maaf Password atau Username Anda Salah");
            }
            connection.Close();
        }
    }
}
