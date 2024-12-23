
using Kuaför_Randevu_Uygulaması.Resources;
using System.Windows.Forms;

namespace Kuaför_Randevu_Uygulaması
{
    internal static class Program
    {

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
  
        }
    }
}