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
    public partial class gestionareGrupe : Form
    {
        public gestionareGrupe()
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
            foreach (String departament in Departamente)
            {
                comboBox2.Items.Add(departament);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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
