
using Kuaför_Randevu_Uygulaması.Resources;

namespace Kuaför_Randevu_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm6 = new Form6();
            frm6.ShowDialog();  
        }
    }
}
