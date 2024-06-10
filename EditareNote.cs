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
    public partial class EditareNote : Form
    {
        static string connectionSQL = "Server = uni-catalog.cj6s8sok2i2r.us-east-1.rds.amazonaws.com; Port = 3306; Database = UniCatalog; Uid = admin; Pwd = kristalypoo;";
        public static MySqlConnection connection = new MySqlConnection(connectionSQL);
        public EditareNote(string nume, string prenume, string disciplina, string nota, string grupa)
        {
            InitializeComponent();

            textBox1.Text = nume;
            textBox2.Text = prenume;
            textBox3.Text = disciplina;
            textBox4.Text = nota;
            textBox6.Text = grupa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nume = textBox1.Text;
            string prenume = textBox2.Text;
            string disciplina = textBox3.Text;
            string nota = textBox4.Text;
            string data = dateTimePicker1.Text;
            string grupa = textBox6.Text;


            if (string.IsNullOrWhiteSpace(nota))
            {
                nota = "0";
                MessageBox.Show("Eroare editare notă!");
            }

            double nota_val = double.Parse(nota);


            if(nota_val > 10 || nota_val <= 0)
            {
                MessageBox.Show("Valoare invalidă pentru notă!");
            }

            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO catalog(student_id, disciplina_id, data, nota) VALUES ((SELECT id FROM studenti WHERE nume = '" +nume+ "' AND prenume = '" +prenume+ "' AND grupa_id = (SELECT id FROM grupa WHERE nume = '" + grupa + "')), (SELECT id FROM disciplina WHERE nume = '" + disciplina+ "'), '" +data+ "', '" +nota+ "')";
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
