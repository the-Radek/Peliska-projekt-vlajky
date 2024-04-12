namespace projekt_programování_vlajky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Vytvořte novou instanci Form2
            Form2 form2 = new Form2();

            // Zobrazte Form2
            form2.Show();

            // Skryjte Form1
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Vytvořte novou instanci Form2
            Form3 form3 = new Form3();

            // Zobrazte Form2
            form3.Show();

            // Skryjte Form1
            this.Hide();
        }
    }
}