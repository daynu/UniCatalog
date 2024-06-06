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
    }
}
