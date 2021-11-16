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
    public partial class Products : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ASUS\source\repos\BetaMart_NadiaPutriR_29_XIIRPL4\BetaMart_NadiaPutriR_29_XIIRPL4\DB_BetaMart_NadiaPutriR.accdb");
        public Products()
        {
            InitializeComponent();
        }

        void showData()
        {
            connection.Open();
            string printah = "select * from TB_ProdukBetaMart";
            OleDbDataAdapter da = new OleDbDataAdapter(printah, connection);
            DataTable dtable = new DataTable();
            da.Fill(dtable);
            dataProduk.DataSource = dtable;
            connection.Close();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (boxId.Text != "")
            {
                MessageBox.Show("ID tidak boleh di isi!!!");
            }
            else
            {
                connection.Open();
                string printah = "INSERT INTO TB_ProdukBetaMart (NamaProduk, SatuanProduk, UkuranGram, StokProduk) values ('" + boxNama.Text + "', '" + boxSatuan.Text + "', '" + boxSize.Text + "', '" + boxStok.Text + "')";
                OleDbCommand cmd = new OleDbCommand(printah, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data produk berhasil Disimpan");
                showData();
                clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            string printah = "UPDATE TB_ProdukBetaMart SET NamaProduk='" + boxNama.Text + "', SatuanProduk='" + boxSatuan.Text + "', UkuranGram='" + boxSize.Text + "', StokProduk='" + boxStok.Text + "'WHERE ID =" + boxId.Text + "";
            OleDbCommand cmd = new OleDbCommand(printah, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data Produk berhasil Diupdate");
            showData();
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            string printah = "DELETE FROM TB_ProdukBetaMart WHERE ID =" + boxId.Text + "";
            OleDbCommand cmd = new OleDbCommand(printah, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data Produk berhasil Dihapus");
            showData();
            clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            connection.Open();


            string printah = "select * from TB_ProdukBetaMart where ID =" + boxSearch.Text + "";
            OleDbDataAdapter da = new OleDbDataAdapter(printah, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataProduk.DataSource = dt;

            connection.Close();
            clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void clear()
        {
            boxId.ResetText();
            boxNama.ResetText();
            boxSatuan.ResetText();
            boxSize.ResetText();
            boxStok.ResetText();
        }
    }
}
