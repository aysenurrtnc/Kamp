using System;

namespace ClassMetotDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = "123456789";
            musteri1.Name = "Ayşenur";
            musteri1.Surname = "Tunç";
            musteri1.Gender = "Kadın";

            Musteri musteri2 = new Musteri();
            musteri2.Id = "123456669";
            musteri2.Name = "Eda";
            musteri2.Surname = "Aslan";
            musteri2.Gender = "Kadın";

            Musteri musteri3 = new Musteri();
            musteri3.Id = "123456999";
            musteri3.Name = "Ali";
            musteri3.Surname = "Karan";
            musteri3.Gender = "Erkek";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("-------------------------------------------");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            musteriManager.Listele(musteriler);

            Console.WriteLine("-------------------------------------------");

            musteriManager.Sil(musteri1);


        }
    }
}
