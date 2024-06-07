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
    public partial class gestionareNote : Form
    {
        public gestionareNote()
        {
            InitializeComponent();
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

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            String grupa = comboBox5.SelectedItem.ToString();
            List<Student> studenti = new StudentiDAO().GetStudenti(grupa);
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
            List<String> Discipline = CatalogDAO.getDisciplina(program, an);
            comboBox6.Items.Clear();
            comboBox6.Text = "Disciplina";
            foreach (String disciplina in Discipline)
            {
                comboBox6.Items.Add(disciplina);
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
