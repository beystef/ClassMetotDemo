using System;

namespace ClassMetotDemo
{
    class main
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri(), m2 = new Musteri(), m3 = new Musteri(); 
            Musteri[] Musteriler = new Musteri[] {m1, m2, m3};

            m1.Id = "1234m1";
            m1.Ad = "Mehmet";
            m1.Soyad = "Kükrek";
            m1.Yas = 21;
            m1.Para = 11111;

            m2.Id = "5678m2";
            m2.Ad = "Yusuf";
            m2.Soyad = "Kaplan";
            m2.Yas = 37;
            m2.Para = 32323;

            m3.Id = "8642m3";
            m3.Ad = "Eren";
            m3.Soyad = "Yüzlüoğlu";
            m3.Yas = 19;
            m3.Para = 673;

            MusteriManager mManager = new MusteriManager();           

            mManager.Ekle(m1);
            mManager.Ekle(m2);
            mManager.Ekle(m3);

            Console.WriteLine("---------------");

            mManager.Sirala(Musteriler);

            mManager.Sil(m1);
            mManager.Sil(m2);
            mManager.Sil(m3);

            Console.ReadLine();
        }
    }
}
