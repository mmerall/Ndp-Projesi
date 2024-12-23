
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuaför_Randevu_Uygulaması.Resources
{
    public class Hizmetli1 : Hizmetliler
    {

        public Hizmetli1(string text, string text1, string text2,string text3, string selectedComboBox1Item, string selectedComboBox2Item, string selectedComboBox3Item)
        : base(text, text1, text2,text3 , selectedComboBox1Item, selectedComboBox2Item, selectedComboBox3Item)
        {
            
        }

        public override void RandevuDüzenle(string eskiRandevu, string yeniRandevu)
        {
            Form4 frm4 = new Form4();
            string dosyaYolu = @"C:\Users\misra\OneDrive\Masaüstü\NDPPROJE\Müşteriler.txt";

            try
            {
                if (File.Exists(dosyaYolu))
                {
                    var satırlar = File.ReadAllLines(dosyaYolu).ToList();

                    int index = satırlar.FindIndex(s => s == eskiRandevu);
                    if (index != -1)
                    {
                       
                        satırlar.RemoveAt(index);
                        File.WriteAllLines(dosyaYolu, satırlar);
                        frm4.listBox1.Items.Remove(eskiRandevu);

                        
                        satırlar.Add(yeniRandevu);
                        File.WriteAllLines(dosyaYolu, satırlar);

                       
                        frm4.listBox1.Items.Add(yeniRandevu);
                    }
                    else
                    {
                        MessageBox.Show("Güncellenecek randevu bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Dosya bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dosya güncelleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void RandevuOluştur(string dosyaadresi)
        {
            if (File.Exists(dosyaadresi))
            {
                
                using (StreamWriter stryaz = File.AppendText(dosyaadresi))
                {
                    
                    stryaz.Write(text + " ");
                    stryaz.Write(text1 + " ");
                    stryaz.Write(text2 + " ");
                    
                    stryaz.Write(selectedComboBox1Item + " ");

                    stryaz.Write(selectedComboBox2Item + " ");
                    stryaz.Write(text3 + " ");
                    stryaz.Write(selectedComboBox3Item + " ");
                    stryaz.Write(text4 + " ");
                    stryaz.Write(selectedComboBox6Item + "\n");
                }

            }
            else
            {
                MessageBox.Show(dosyaadresi + " bulunamadı");
            }
        }

        public override void RandevuSil(string silineceköğe)
        {
            Form4 frm4 = new Form4();

            string dosyaYolu = @"C:\Users\misra\OneDrive\Masaüstü\NDPPROJE\Müşteriler.txt";
            if (File.Exists(dosyaYolu))
            {
                var satirlar = File.ReadAllLines(dosyaYolu);
                var yenisatirlar = new List<string>();
                foreach (var satir in satirlar)
                {
                    if (satir != silineceköğe)
                    {
                        yenisatirlar.Add(satir);
                    }
                }
                File.WriteAllLines(dosyaYolu, yenisatirlar.ToArray());
            }
            else
            {
                MessageBox.Show("Dosya Bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


    }
}
