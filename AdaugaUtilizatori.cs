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

namespace UniCatalog
{
    public partial class AdaugaUtilizatori : Form
    {
        static string connectionSQL = "Server = uni-catalog.cj6s8sok2i2r.us-east-1.rds.amazonaws.com; Port = 3306; Database = UniCatalog; Uid = admin; Pwd = kristalypoo;";
        public static MySqlConnection connection = new MySqlConnection(connectionSQL);
        public AdaugaUtilizatori()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = textBox1.Text;
            string prenume = textBox2.Text;
            string parola = textBox3.Text;
            string rol = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "Rol";
            if (nume != "" && prenume != "" && parola != "" && rol != "Rol")
            {

                new UtilizatoriDAO().AddUtilizator(nume, prenume, parola, rol);
                MessageBox.Show("Utilizator adaugat cu succes!");
            }
            else
            {
                MessageBox.Show("Toate campurile sunt obligatorii!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
