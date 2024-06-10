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
    public partial class AdaugaGrupa : Form
    {

        public AdaugaGrupa()
        {
            InitializeComponent();
            List<String> facultati = FacultatiDAO.GetFacultati();
            foreach (String facultate in facultati)
            {
                comboBox1.Items.Add(facultate);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String numeGrupa = textBox1.Text;
            String an = textBox2.Text;
            String Facultate = comboBox1.SelectedItem.ToString();
            String Departament = comboBox2.SelectedItem.ToString();
            String Program = comboBox3.SelectedItem.ToString();
            FacultatiDAO.adaugaGrupa(numeGrupa, an, Program);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String facultate = comboBox1.SelectedItem.ToString();
            List<String> Departamente = FacultatiDAO.getDepartamente(facultate);
            foreach (String departament in Departamente)
            {
                comboBox2.Items.Add(departament);
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String departament = comboBox2.SelectedItem.ToString();
            List<String> Programe = FacultatiDAO.getPrograme(departament);
            foreach (String program in Programe)
            {
                comboBox3.Items.Add(program);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
