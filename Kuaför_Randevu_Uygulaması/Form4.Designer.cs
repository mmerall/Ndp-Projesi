namespace Kuaför_Randevu_Uygulaması
{
    partial class Form4
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnAra = new Button();
            txtArama = new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ImeMode = ImeMode.On;
            listBox1.Location = new Point(88, 47);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(717, 424);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.GreenYellow;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(61, 31);
            button1.TabIndex = 1;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.GreenYellow;
            button2.Location = new Point(811, 47);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 2;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.GreenYellow;
            button3.Location = new Point(811, 86);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 3;
            button3.Text = "Düzenle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnAra
            // 
            btnAra.BackColor = Color.GreenYellow;
            btnAra.Location = new Point(810, 125);
            btnAra.Margin = new Padding(3, 4, 3, 4);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(86, 31);
            btnAra.TabIndex = 4;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // txtArama
            // 
            txtArama.Location = new Point(88, 13);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(717, 27);
            txtArama.TabIndex = 5;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_1473878_1280;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(914, 600);
            Controls.Add(txtArama);
            Controls.Add(btnAra);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Randevu Düzenle";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnAra;
        private TextBox txtArama;
    }
}