using System;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle(Musteri mx)
        {
            Console.WriteLine("Yeni Üyemiz Çok Yaşa");
            Console.WriteLine("Ad: " + mx.Ad);
            Console.WriteLine("Soyad:" + mx.Soyad);
        }
        public void Sil(Musteri my)
        {
            Console.WriteLine("Bir müşterinin bizi kaybetmiş olması çok üzücü...:(");
            Console.WriteLine("Ad: " + my.Ad);
            Console.WriteLine("Soyad:" + my.Soyad);
        }
        public void Sirala(Musteri[] mz)
        {
            Console.WriteLine("Müşterilerimiz:");
            Console.WriteLine("---------------");
            foreach (Musteri m in mz)
            {   
                Console.WriteLine("Id:" + m.Id);
                Console.WriteLine("Ad: " + m.Ad);
                Console.WriteLine("Soyad:" + m.Soyad);
                Console.WriteLine("Yas:" + m.Yas);
                Console.WriteLine("Para:" + m.Para);
                Console.WriteLine("---------------");  
            }
        }     
    }
}