using System;

namespace Homeworks
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.UrunAdi = "Tablet";
            urun1.Fiyati = 1.540;
            urun1.SaticiAdi = "Samsung";
            urun1.Rengi = "Gri";

            Product urun2 = new Product();
            urun2.UrunAdi = "Kablosuz Mouse";
            urun2.Fiyati = 104.90;
            urun2.SaticiAdi = "Xioami";
            urun2.Rengi = "Siyah";

            Product urun3 = new Product();
            urun3.UrunAdi = "Uydu Alıcılı LED TV";
            urun3.Fiyati = 1.099;
            urun3.SaticiAdi = "Next YE";
            urun3.Rengi = "Siyah";

            Product urun4 = new Product();
            urun4.UrunAdi = "Telefon";
            urun4.Fiyati = 7.489;
            urun4.SaticiAdi = "Apple";
            urun4.Rengi = "Mor";

            Product[] urunler = new Product[] { urun1, urun2, urun3, urun4 };

            for (int i = 0; i < urunler.Length; ++i)
            {
                Console.WriteLine(urunler[i].UrunAdi + " " + urunler[i].Fiyati);
            }
            

            foreach (Product product in urunler)
            {
                Console.WriteLine(product.UrunAdi + " " + product.SaticiAdi);

            }

            int j = 0;
            while (j < urunler.Length)
            {
                Console.WriteLine(urunler[j].Rengi);
                ++j;
            }


            
        }
    }

    class Product
    {
        public string UrunAdi { get; set; }
        public double Fiyati { get; set; }
        public string SaticiAdi { get; set; }
        public string Rengi { get; set; }
    }
}
