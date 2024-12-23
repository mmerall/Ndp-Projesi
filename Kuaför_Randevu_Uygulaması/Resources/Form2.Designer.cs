namespace Kuaför_Randevu_Uygulaması.Resources
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.GreenYellow;
            button1.Location = new Point(106, 43);
            button1.Name = "button1";
            button1.Size = new Size(163, 56);
            button1.TabIndex = 0;
            button1.Text = "Randevu Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.GreenYellow;
            button2.Location = new Point(501, 43);
            button2.Name = "button2";
            button2.Size = new Size(163, 56);
            button2.TabIndex = 1;
            button2.Text = "Randevu Düzenle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.GreenYellow;
            button3.Location = new Point(1, 0);
            button3.Name = "button3";
            button3.Size = new Size(53, 23);
            button3.TabIndex = 2;
            button3.Text = "Geri";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_1473878_1280;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Randevu Ayarlama";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}