using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            switch (dolarDun > dolarBugun)
            {
                case true:
                    Console.WriteLine("Azalış butonu");
                    break;
                default:
                {
                    if (dolarDun < dolarBugun)
                    {
                        Console.WriteLine("Artış butonu");
                    }
                    else
                    {
                        Console.WriteLine("Değişmedi butonu");
                    }

                    break;
                }
            }

          
            

            
            Console.WriteLine(sistemeGirisYapmisMi == true ? "Kullanıcı ayarları butonu" : "Giriş yap butonu");

            Console.WriteLine(dolarDun > dolarBugun ? "Azalış butonu" : dolarDun < dolarBugun ? "Artış butonu" : "Değişmedi butonu");

            Console.WriteLine(kategoriEtiketi);
            
        }
    }
}
