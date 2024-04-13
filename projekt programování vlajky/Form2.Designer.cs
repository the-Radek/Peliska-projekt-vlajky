namespace projekt_programování_vlajky
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            pictureBox7 = new PictureBox();
            label6 = new Label();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 192, 128);
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 0;
            label1.Text = "Guess ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(192, 192, 255);
            label2.Location = new Point(54, 26);
            label2.Name = "label2";
            label2.Size = new Size(81, 17);
            label2.TabIndex = 1;
            label2.Text = "the colour";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 255, 128);
            label3.Location = new Point(20, 43);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 2;
            label3.Text = "of the flag";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(703, 12);
            button1.Name = "button1";
            button1.Size = new Size(85, 46);
            button1.TabIndex = 3;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(312, 304);
            button2.Name = "button2";
            button2.Size = new Size(214, 50);
            button2.TabIndex = 4;
            button2.Text = "Click and choose colours";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(128, 128, 255);
            label4.Location = new Point(212, 252);
            label4.Name = "label4";
            label4.Size = new Size(195, 21);
            label4.TabIndex = 5;
            label4.Text = "Name of the country:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(255, 255, 128);
            label5.Location = new Point(475, 252);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 6;
            label5.Text = "label5";
            label5.Click += label5_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(345, 127);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(155, 101);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Plum;
            label6.Location = new Point(377, 77);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 14;
            label6.Text = "The flag:";
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(255, 192, 128);
            button3.Location = new Point(436, 362);
            button3.Name = "button3";
            button3.Size = new Size(75, 33);
            button3.TabIndex = 15;
            button3.Text = "Next";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Font = new Font("Rockwell", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(128, 128, 255);
            button4.Location = new Point(345, 363);
            button4.Name = "button4";
            button4.Size = new Size(73, 32);
            button4.TabIndex = 16;
            button4.Text = "Check";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Plum;
            label7.Location = new Point(615, 333);
            label7.Name = "label7";
            label7.Size = new Size(65, 21);
            label7.TabIndex = 17;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaptionText;
            label8.Font = new Font("Rockwell", 16.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(255, 192, 128);
            label8.Location = new Point(342, 21);
            label8.Name = "label8";
            label8.Size = new Size(76, 25);
            label8.TabIndex = 18;
            label8.Text = "Score:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaptionText;
            label9.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(255, 255, 128);
            label9.Location = new Point(436, 24);
            label9.Name = "label9";
            label9.Size = new Size(65, 21);
            label9.TabIndex = 19;
            label9.Text = "label9";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ActiveCaptionText;
            label10.Font = new Font("Rockwell", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(255, 255, 128);
            label10.Location = new Point(507, 25);
            label10.Name = "label10";
            label10.Size = new Size(75, 21);
            label10.TabIndex = 20;
            label10.Text = "label10";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(pictureBox7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.White;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox7;
        private Label label6;
        private Button button3;
        private Button button4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}