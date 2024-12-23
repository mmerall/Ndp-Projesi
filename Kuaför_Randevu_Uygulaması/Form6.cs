
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

namespace Kuaför_Randevu_Uygulaması
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.ShowDialog();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            for (int i = 0; i < frm3.comboBox2.Items.Count; i++)
            {
                listBox1.Items.Add(frm3.comboBox2.Items[i]);
            }
        }
    }
}
