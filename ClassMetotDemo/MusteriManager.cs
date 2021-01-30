using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Add(Musteri musteri)
        {
            Console.WriteLine("Adı : "+musteri.MusteriAdi+"  Soyadı : "+musteri.Soyadi+" Yaşı : "+musteri.Yasi+"  Olan Müşteri sisteme eklendi.");

        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Adı : "+musteri.MusteriAdi+"  Soyadı : "+musteri.Soyadi+"  Yaşı : "+musteri.Yasi+" Olan Müşteri Sistemden Silindi." );
        }

        public void List(Musteri[] musteri)
        {
            foreach (var x in musteri)
            {
                Console.WriteLine(x.Id+" "+x.MusteriAdi+ " " +x.Soyadi+" "+x.Yasi);
            }
            Console.WriteLine();
        }
    }
}
