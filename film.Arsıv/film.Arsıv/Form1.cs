using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace film.Arsıv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = "Server=localhost;Database=film_arsiv;Uid=root;Pwd='';";
        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                baglanti.Open();
                string sorgu = "SELECT *FROM filmler";
                MySqlCommand cmd =new MySqlCommand(sorgu,baglanti);
                MySqlDataAdapter adapter= new MySqlDataAdapter(cmd);
                DataTable tablo = new DataTable();

                adapter.Fill(tablo);

                dgvFilmler.DataSource = tablo;
                
                
                   


            }


        }
    }
}
