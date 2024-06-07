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
    public partial class AdaugaStudent : Form
    {
        static string connectionSQL = "Server = uni-catalog.cj6s8sok2i2r.us-east-1.rds.amazonaws.com; Port = 3306; Database = UniCatalog; Uid = admin; Pwd = kristalypoo;";
        public static MySqlConnection connection = new MySqlConnection(connectionSQL);
        public String grupa;
        public AdaugaStudent(String grupa)
        {
            InitializeComponent();
            button1.Text = "Adauga student in grupa " + grupa;
            this.grupa = grupa;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nume = textBox1.Text;
            String prenume = textBox2.Text;
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO studenti (nume, prenume, grupa_id) VALUES ('" + nume + "', '" + prenume + "', (SELECT id FROM grupa WHERE nume = '" + this.grupa + "'))";
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
