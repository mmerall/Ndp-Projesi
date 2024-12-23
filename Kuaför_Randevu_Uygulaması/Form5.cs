
using Kuaför_Randevu_Uygulaması.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kuaför_Randevu_Uygulaması
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.ShowDialog();

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            for (int i = 0; i < frm3.comboBox1.Items.Count; i++)
            {
                listBox1.Items.Add(frm3.comboBox1.Items[i]);
            }

        }
    }
}
