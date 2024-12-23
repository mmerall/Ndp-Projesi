
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuaför_Randevu_Uygulaması.Resources
{
    public abstract class Hizmetliler
    {
        protected string text;
        protected string text1;
        protected string text2;
        protected string text3;
        protected string text4;
        protected string selectedComboBox1Item;
        protected string selectedComboBox2Item;
        protected string selectedComboBox3Item;
        protected string selectedComboBox6Item;
        
        public Hizmetliler(string text, string text1, string text2,string text3 ,string selectedComboBox1Item, string selectedComboBox2Item, string selectedComboBox3Item)
        {
            this.text = text;
            this.text1 = text1;
            this.text2 = text2;
            
         
            this.selectedComboBox1Item = selectedComboBox1Item;
            this.selectedComboBox2Item = selectedComboBox2Item;
            this.text3 = text3;
            this.selectedComboBox3Item = selectedComboBox3Item;
            
        }
        public abstract void RandevuOluştur(string dosyaadresi);
        public abstract void RandevuSil(string silineceköğe);
        public abstract void RandevuDüzenle(string eskiRandevu, string yeniRandevu);




    }
}
