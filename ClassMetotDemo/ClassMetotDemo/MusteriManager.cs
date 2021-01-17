using System;
namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + " " + "eklendi.");
        }

        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("Mevcut müşteriler: ");

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Name + " " + musteri.Surname);
            }
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + " " + "silindi.");
        }
           




    }
}