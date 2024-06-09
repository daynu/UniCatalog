using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniCatalog
{
    public partial class gestionareUtilizatori : Form
    {
        public gestionareUtilizatori()
        {
            InitializeComponent();
        }

        private void gestionareUtilizatori_Load(object sender, EventArgs e)
        {
            List<Utilizator> utilizatori = new UtilizatoriDAO().GetUtilizatori();
            dataGridView1.DataSource = utilizatori;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdaugaUtilizatori adaugaUtilizatori = new AdaugaUtilizatori();
            adaugaUtilizatori.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {  
            try
            {
                string nume = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string prenume = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string parola = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                new UtilizatoriDAO().DeleteUtilizator(prenume, nume, parola);
                MessageBox.Show("Utilizator sters cu succes!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Selectati un utilizator prin click stanga pe casuta libera din stanga randului ");
            }
            dataGridView1.DataSource = new UtilizatoriDAO().GetUtilizatori();
        }
    }
}
