using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace projekt_programování_vlajky
{
    public partial class Form2 : Form
    {
        Random generator = new Random();
        private Dictionary<string, string> flagPaths = new Dictionary<string, string>();
        private Dictionary<string, string> colorFlagPaths = new Dictionary<string, string>();
        ColorDialog colorDialog1 = new System.Windows.Forms.ColorDialog();
        List<System.Windows.Forms.Button> seznam = new List<System.Windows.Forms.Button>();
        int i = 0;
        int score = 0;


        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Pokud brava není předdefinovaná
                if (!Values.ColorNames.ContainsKey(colorDialog1.Color.Name))
                {
                    MessageBox.Show("pls selektni nějakou definovanou barvu"); // TODO změnit text
                    //MessageBox.Show(colorDialog1.Color.Name); // Vypíše nepřeložený "název" barvy
                    return;
                }

                System.Windows.Forms.Button b = new System.Windows.Forms.Button();
                b.BackColor = colorDialog1.Color;
                b.Top = 300;
                b.Left = 550 + i * 30;
                seznam.Add(b);
                this.Controls.Add(seznam[i]);

                // Přidá na tlačítko funkcionalitu
                b.Click += (object? sender, EventArgs e) => {
                    //MessageBox.Show(Values.ColorNames[b.BackColor.Name]); // Vypíše název barvy
                    // Pokud je tlačítko poslední smaže text
                    if (seznam.IndexOf(b) == i - 1)
                        label7.Text = "";

                    // Smaže tlačítko z formuláře
                    this.Controls.Remove(b);
                    // Smaže tlačítko ze seznamu
                    seznam.Remove(b);
                    // Sníží čítač
                    i--;

                    // Přeskládá barvičky vedle sebe
                    int j = 0;
                    foreach (System.Windows.Forms.Button item in seznam)
                    {
                        item.Left = 550 + j * 30;
                        j++;
                    }
                };

                // Zobrazí název barvy
                label7.Text = Values.ColorNames[b.BackColor.Name];

                i++;
            }
        }

        private void LoadFlagPaths()
        {
            flagPaths.Add("Velká Británie", @"vlajky\img1.jpg");
            flagPaths.Add("Česká republika", @"vlajky\img2.jpg");
            flagPaths.Add("Rakousko", @"vlajky\img3.jpg");
            flagPaths.Add("Dánsko", @"vlajky\img4.jpg");
            flagPaths.Add("Francie", @"vlajky\img5.jpg");
            flagPaths.Add("Řecko", @"vlajky\img6.jpg");
            flagPaths.Add("Makedonie", @"vlajky\img7.jpg");
            flagPaths.Add("Kanada", @"vlajky\img8.jpg");
            flagPaths.Add("Itálie", @"vlajky\img9.jpg");
            flagPaths.Add("Nizozemsko", @"vlajky\img10.jpg");
            flagPaths.Add("Lucembursko", @"vlajky\img11.jpg");
            flagPaths.Add("Litva", @"vlajky\img12.jpg");
            flagPaths.Add("Rusko", @"vlajky\img13.jpg");
            flagPaths.Add("Rumunsko", @"vlajky\img14.jpg");
            flagPaths.Add("Španělsko", @"vlajky\img15.jpg");
            flagPaths.Add("Švédsko", @"vlajky\img16.jpg");
            flagPaths.Add("Švýcarsko", @"vlajky\img17.jpg");

            //// alternativně přes třídu Values
            //flagPaths = Values.FlagPaths.ToDictionary(entry => entry.Key, entry => entry.Value);
        }


        private Random random = new Random();
        private void ShowRandomFlag()
        {
            if (flagPaths.Count == 0)
            {
                MessageBox.Show("Všechny vlajky již byly zobrazeny, hra končí!\nTvoje skóre je " + score.ToString());
                return;
            }

            int index = random.Next(flagPaths.Count);
            KeyValuePair<string, string> randomFlag = flagPaths.ElementAt(index);

            string countryName = randomFlag.Key;
            string imagePath = randomFlag.Value;

            pictureBox7.Image = Image.FromFile(imagePath);
            label5.Text = countryName;
            label7.Text = "";
            label9.Text = score.ToString();
            label10.Text = "";

            // Odstranění zobrazené vlajky ze slovníku
            flagPaths.Remove(countryName);
        }

       
        private void Form2_Load(object sender, EventArgs e)
        {
            int cislo = generator.Next(1, 17);
            string imagePath = @"vlajky\img" + cislo + ".jpg";

            // Načteme obrázek 
            Image originalImage = Image.FromFile(imagePath);

            //Vytvoříme nový Bitmap s konkrétní vlastností
            Bitmap resizedImage = new Bitmap(originalImage, new Size(345, 127));

            // Nastavíme nová Bitmap do Picture boxu
            pictureBox7.Image = resizedImage;

            originalImage.Dispose();

            
            
                LoadFlagPaths();
                ShowRandomFlag();
            
        }

       

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Zavře Form2
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            foreach (System.Windows.Forms.Button item in seznam)
            {
                this.Controls.Remove(item);

            }

            // Vyčistí seznam barev
            this.seznam.Clear();
            i = 0;

            // Povolí check tlačítko
            button4.Enabled = true;

            buttonNext_Click(sender, e);
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            ShowRandomFlag(); // Zobrazit další náhodnou vlajku po kliknutí na tlačítko "Next"
        }


        private void button4_Click(object sender, EventArgs e)
        {
            bool correct = false;

            // Pokud se délka pole barviček rovná délce pole referenčního řešení, zkontroluj...
            if (seznam.Count == Values.FlagColorList[label5.Text].Count())
            {
                correct = true;
                // Pro každou barvu zkontroluj jestli je v referenčním řešení
                foreach (System.Windows.Forms.Button item in seznam)
                {
                    if (!Values.FlagColorList[label5.Text].Contains(Values.ColorNames[item.BackColor.Name]))
                    {
                        correct = false;
                        break;
                    }
                }
            }

            if (correct)
            {
                // přidá skóre
                score++;
                label9.Text = score.ToString();
                // vypíše zprávu do labelu a změnní barvu
                label10.Text = "good";
                label10.ForeColor = Color.FromArgb(119, 221, 118);
            }
            else
            {
                // vypíše zprávu do labelu a změnní barvu
                label10.Text = "bad";
                label10.ForeColor = Color.FromArgb(255, 105, 97);
            }

            // Obarví vlajku
            string colorFlagPath = Values.ColorFlagPaths[label5.Text];
            pictureBox7.Image = Image.FromFile(colorFlagPath);

            // Zakáže check tlačítko
            button4.Enabled = false;
        }

    }
}
