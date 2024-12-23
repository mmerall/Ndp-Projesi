
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace Kuaför_Randevu_Uygulaması.Resources
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.Format = DateTimePickerFormat.Short;

        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port = 5432; Database = KuaforDB2; user Id = postgres; password=1234");
        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
            string.IsNullOrWhiteSpace(textBox2.Text) ||
            string.IsNullOrWhiteSpace(textBox3.Text) || 
            comboBox1.SelectedItem == null ||
            comboBox2.SelectedItem == null ||
            comboBox3.SelectedItem == null 
            )
            {

                MessageBox.Show("Lütfen tüm bilgileri girin.");
                return;
            }

            else
            {
                

                string text = textBox1.Text.Trim();
                string text1 = textBox2.Text.Trim();
                string text2 = textBox3.Text.Trim();
                string text3 = dateTimePicker1.Text;
                
                string selectedComboBox1Item = comboBox1.SelectedItem?.ToString();
                string selectedComboBox2Item = comboBox2.SelectedItem?.ToString();
                string selectedComboBox3Item = comboBox3.SelectedItem?.ToString();
                


                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
              


                Hizmetli1 hizmetli1 = new Hizmetli1(text, text1, text2,text3, selectedComboBox1Item, selectedComboBox2Item, selectedComboBox3Item);
                hizmetli1.RandevuOluştur(@"C:\Users\misra\OneDrive\Masaüstü\NDPPROJE\Müşteriler.txt");

            }



            try
            {
                // Bağlantıyı aç
                baglanti.Open();

                // textBox3'teki değeri al
                string telNo = textBox3.Text;

                // Eğer textBox3'teki değer boş değilse, veritabanına ekle
                if (!string.IsNullOrWhiteSpace(telNo))
                {
                    string query = "INSERT INTO \"Musteriler\" (\"telNo\") VALUES (@telNo)";
                    using (NpgsqlCommand komut = new NpgsqlCommand(query, baglanti))
                    {
                        // Parametre ekle
                        komut.Parameters.AddWithValue("@telNo", telNo);
                        komut.ExecuteNonQuery();
                    }

                    MessageBox.Show("Telefon numarası başarıyla tabloya eklendi!");
                }
                else 
                {
                    MessageBox.Show("Telefon numarası başarıyla tabloya eklendi!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                baglanti.Close();
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {



            comboBox3.Items.Add(" ");




        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }
    }
}
