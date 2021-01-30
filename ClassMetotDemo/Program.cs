using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri Musteri1 = new Musteri();
            Musteri1.Id = 1;
            Musteri1.MusteriAdi = "Yağmur";
            Musteri1.Soyadi = "Aslan";
            Musteri1.Yasi =25;


            Musteri Musteri2 = new Musteri();
            Musteri2.Id = 2;
            Musteri2.MusteriAdi = "Ahmet";
            Musteri2.Soyadi = "Yıldız";
            Musteri2.Yasi = 40;

            Musteri Musteri3 = new Musteri();
            Musteri3.Id = 3;
            Musteri3.MusteriAdi = "Gülsüm";
            Musteri3.Soyadi = "Yılmaz";
            Musteri3.Yasi = 16;

            Musteri Musteri4 = new Musteri();
            Musteri4.Id = 4;
            Musteri4.MusteriAdi = "Kadir";
            Musteri4.Soyadi = "Kaya";
            Musteri4.Yasi = 36;

            Musteri[] musteriler = new Musteri[] {Musteri1,Musteri2,Musteri3,Musteri4 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("Ekle");
            musteriManager.Add(Musteri1);

            Console.WriteLine("Sil");
            musteriManager.Delete(Musteri2);

            Console.WriteLine("listele");
            musteriManager.List(musteriler);





            Console.WriteLine("Hello World!");
        }
    }
}
