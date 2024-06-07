using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace UniCatalog
{
    public partial class Main : Form
    {
        private Utilizator user;
        public Main(Utilizator user)
        {
            InitializeComponent();
            this.user = user;
            label2.Text = user.Nume + " " + user.Prenume;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gestionareUtilizatori gestionareUtilizatori = new gestionareUtilizatori();
            gestionareUtilizatori.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gestionareGrupe gestionareGrupe = new gestionareGrupe();
            gestionareGrupe.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gestionareNote gestionareNote = new gestionareNote();
            gestionareNote.Show();
        }
    }
}
