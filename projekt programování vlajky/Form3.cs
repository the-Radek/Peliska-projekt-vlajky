using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_programování_vlajky
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // Vytvořte novou instanci Form2
                Form1 form1 = new Form1();

                // Zobrazte Form2
                form1.Show();

                // Skryjte Form1
                this.Hide();
            }
        }
    }
}
