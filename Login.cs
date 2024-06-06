using Newtonsoft.Json;
using System;

namespace UniCatalog
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String password = textBox2.Text;
            List<Utilizator> utilizatori = new UtilizatoriDAO().GetUtilizatori();
            bool found = false;
            foreach (Utilizator utilizator in utilizatori)
            {
                if (utilizator.Nume + " " + utilizator.Prenume == name && utilizator.Parola == password)
                {
                    Main main = new Main(utilizator);
                    main.Show();
                    this.Hide();
                    found = true;
                    return;
                }
            }
            if (!found)
            {
                MessageBox.Show("Nume sau parola incorecta");
            }
        }   
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
