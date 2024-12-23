namespace Kuaför_Randevu_Uygulaması
{
    partial class Form6
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
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.GreenYellow;
            button1.Location = new Point(1, 0);
            button1.Name = "button1";
            button1.Size = new Size(53, 23);
            button1.TabIndex = 0;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Britannic Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(76, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(628, 310);
            listBox1.TabIndex = 1;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_1473878_1280;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Çalışanlarımız";
            Load += Form6_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
    }
}