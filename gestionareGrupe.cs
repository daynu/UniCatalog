using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class gestionareGrupe : Form
    {
        static string connectionSQL = "Server = uni-catalog.cj6s8sok2i2r.us-east-1.rds.amazonaws.com; Port = 3306; Database = UniCatalog; Uid = admin; Pwd = kristalypoo;";
        public static MySqlConnection connection = new MySqlConnection(connectionSQL);
        public gestionareGrupe()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            List<String> facultati = FacultatiDAO.GetFacultati();
            foreach (String facultate in facultati)
            {
                comboBox1.Items.Add(facultate);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String facultate = comboBox1.SelectedItem.ToString();
            List<String> Departamente = FacultatiDAO.getDepartamente(facultate);
            comboBox2.Items.Clear();
            comboBox2.Text = "Departamentul";
            comboBox3.Items.Clear();
            comboBox3.Text = "Program de Studiu";
            comboBox5.Items.Clear();
            comboBox5.Text = "Grupa";
            foreach (String departament in Departamente)
            {
                comboBox2.Items.Add(departament);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String departament = comboBox2.SelectedItem.ToString();
            List<String> Programe = FacultatiDAO.getPrograme(departament);
            comboBox3.Items.Clear();
            comboBox3.Text = "Program de Studiu";
            comboBox5.Items.Clear();
            comboBox5.Text = "Grupa";
            foreach (String program in Programe)
            {
                comboBox3.Items.Add(program);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.Items.Clear();
            comboBox5.Text = "Grupa";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdaugaGrupa adaugaGrupa = new AdaugaGrupa();
            adaugaGrupa.Show();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            String grupa = comboBox5.SelectedItem.ToString();
            List<Student> studenti = new StudentiDAO().GetStudenti(grupa);
            dataGridView1.DataSource = studenti;

            if (grupa == "Grupa")
            {
                dataGridView1.DataSource = null;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string an = comboBox4.SelectedItem.ToString();
            string program = comboBox3.SelectedItem != null ? comboBox3.SelectedItem.ToString() : "";
            comboBox5.Items.Clear();
            comboBox5.Text = "Grupa";
            List<String> grupe = FacultatiDAO.getGrupa(program, an);
            foreach (String grupa in grupe)
            {
                comboBox5.Items.Add(grupa);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdaugaStudent adaugaStudent = new AdaugaStudent(comboBox5.SelectedItem.ToString());
            adaugaStudent.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string grupa = comboBox5.SelectedItem.ToString();
            try
            {
                string nume = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string prenume = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM studenti WHERE nume = '" + nume + "' AND prenume = '" + prenume + "' AND grupa_id = (SELECT id FROM grupa WHERE nume = '" + grupa + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selectati un student pentru a-l sterge prin click stanga pe casuta libera din stanga randului");
            }
            dataGridView1.DataSource = new StudentiDAO().GetStudenti(grupa);


        }
    }
}
