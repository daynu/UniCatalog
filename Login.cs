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
            List<UtilizatoriDAO.Utilizator> utilizatori = new UtilizatoriDAO().GetUtilizatori();
            foreach (UtilizatoriDAO.Utilizator utilizator in utilizatori)
            {
                if (utilizator.Nume + " " + utilizator.Prenume == name && utilizator.Parola == password)
                {
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    MessageBox.Show("Datele introduse sunt gresite! ERROR");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
