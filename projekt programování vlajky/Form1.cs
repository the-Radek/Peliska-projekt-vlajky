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

            // Zobrazí Form1 při zavření Form2
            form2.Closed += (s, args) => this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Vytvořte novou instanci Form3
            Form3 form3 = new Form3();

            // Zobrazte Form3
            form3.Show();

            // Skryjte Form1
            this.Hide();

            // Zobrazí Form1 při zavření Form3
            form3.Closed += (s, args) => this.Show();
        }
    }
}