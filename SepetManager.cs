using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
   class SepetManager
    {  //naming convention 
    
          public void ekle(Urunler urun )
        {


            Console.WriteLine("Sepete eklendi." + urun.Adi);

        }

        public void ekle2 (string urunAdi , string aciklama , double fiyat)
        {

            Console.WriteLine("Sepete eklendi." + urunAdi);

        }
    }
}
