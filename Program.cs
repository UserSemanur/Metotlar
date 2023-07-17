using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyat = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urunler urun1= new Urunler(); 

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urunler urun2 = new Urunler();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 55;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urunler[] urun = new Urunler[] { urun1, urun2 };

            foreach (var icinde in urun)
            {


                Console.WriteLine(icinde.Adi);  
                Console.WriteLine(icinde.Fiyati);   
                Console.WriteLine(icinde.Aciklama);
                Console.WriteLine("------------------");


            }
            
            Console.WriteLine("----------------------Metotlar----------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.ekle(urun1);
            sepetManager.ekle(urun2);
             
            sepetManager.ekle2 ("armut", " Yeşil Armut",12);
            sepetManager.ekle2("Elma", " Yeşil elma", 12);
            sepetManager.ekle2("Karpuz", " Diyarbakır karpuzu", 12);


        }


    }
}
