
using Kuaför_Randevu_Uygulaması.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Npgsql;

namespace Kuaför_Randevu_Uygulaması
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();

        }

        
        

        private void Form4_Load(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();

            string dosyaYolu = @"C:\Users\misra\OneDrive\Masaüstü\NDPPROJE\Müşteriler.txt";

            using (StreamReader sr = new StreamReader(dosyaYolu))
            {
                string satir;

                while ((satir = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(satir);
                }
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            string text = frm3.textBox1.Text.Trim();
            string text1 = frm3.textBox2.Text.Trim();
            string text2 = frm3.textBox3.Text.Trim();
            string text3 = frm3.dateTimePicker1.Text;
            string? selectedComboBox1Item = frm3.comboBox1.SelectedItem?.ToString();
            string? selectedComboBox2Item = frm3.comboBox2.SelectedItem?.ToString();
            string? selectedComboBox3Item = frm3.comboBox3.SelectedItem?.ToString();
            Hizmetli1 hizmetli1 = new Hizmetli1(text, text1, text2, text3, selectedComboBox1Item, selectedComboBox2Item, selectedComboBox3Item);
            hizmetli1.RandevuSil(listBox1.SelectedItem.ToString());

            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Lütfen silmek için bir öge seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string silineceköge = listBox1.SelectedItem.ToString();
            listBox1.Items.RemoveAt(selectedIndex);

        }


        private void button3_Click(object sender, EventArgs e)
        {

            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Lütfen düzenlemek için bir öge seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string secilenRandevu = listBox1.SelectedItem.ToString();
            string[] bilgiler = secilenRandevu.Split(' ');


            Form3 frm3 = new Form3();
            string text = frm3.textBox1.Text.Trim();
            string text1 = frm3.textBox2.Text.Trim();
            string text2 = frm3.textBox3.Text.Trim();
            string text3 = frm3.dateTimePicker1.Text;

            string selectedComboBox1Item = frm3.comboBox1.SelectedItem?.ToString();
            string selectedComboBox2Item = frm3.comboBox2.SelectedItem?.ToString();
            string selectedComboBox3Item = frm3.comboBox3.SelectedItem?.ToString();
            Hizmetli1 hizmetli1 = new Hizmetli1(text, text1, text2, text3, selectedComboBox1Item, selectedComboBox2Item, selectedComboBox3Item);
            this.Hide();


            frm3.textBox1.Text = bilgiler[0];
            frm3.textBox2.Text = bilgiler[1];
            frm3.textBox3.Text = bilgiler[2];
            frm3.comboBox1.SelectedItem = bilgiler[3];
            frm3.comboBox2.SelectedItem = bilgiler[4];
            frm3.dateTimePicker1.Value = DateTime.ParseExact(bilgiler[5], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            frm3.comboBox3.SelectedItem = bilgiler[6];

            string silineceköge = listBox1.SelectedItem.ToString();
            hizmetli1.RandevuSil(silineceköge);

            if (frm3.ShowDialog() == DialogResult.OK)
            {
                string yeniIsim = string.IsNullOrEmpty(frm3.textBox1.Text) ? bilgiler[0] : frm3.textBox1.Text;
                string yeniSoyisim = string.IsNullOrEmpty(frm3.textBox2.Text) ? bilgiler[1] : frm3.textBox2.Text;
                string yeniBaskaBirAlan = string.IsNullOrEmpty(frm3.textBox3.Text) ? bilgiler[2] : frm3.textBox3.Text;
               
                string yeniComboBox1 = frm3.comboBox1.SelectedItem == null ? bilgiler[3] : frm3.comboBox1.SelectedItem.ToString();
                string yeniComboBox2 = frm3.comboBox2.SelectedItem == null ? bilgiler[4] : frm3.comboBox2.SelectedItem.ToString();
               
                string yeniTarih = frm3.dateTimePicker1.Value.ToString("dd.MM.yyyy");
                string yeniComboBox3 = frm3.comboBox3.SelectedItem == null ? bilgiler[7] : frm3.comboBox3.SelectedItem.ToString();
                string yeniRandevu = $"{yeniIsim} {yeniSoyisim} {yeniBaskaBirAlan} {yeniComboBox1} {yeniComboBox2} {yeniTarih} {yeniComboBox3}";

                hizmetli1.RandevuSil(listBox1.SelectedItem.ToString());
                hizmetli1.RandevuDüzenle(secilenRandevu, yeniRandevu);



                listBox1.Items.Add(yeniRandevu);


            }

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            // TextBox içindeki metni al
            string aramaMetni = txtArama.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                MessageBox.Show("Lütfen aramak için bir metin girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Arama işlemi
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string ogeMetni = listBox1.Items[i].ToString().ToLower();
                if (ogeMetni.Contains(aramaMetni))
                {
                    // Eşleşen öğeyi seç
                    listBox1.SelectedIndex = i;
                    return;
                }
            }

            MessageBox.Show("Aranan metin listede bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
