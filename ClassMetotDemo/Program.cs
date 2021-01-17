using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.TcNo = "11111111111";
            musteri1.Adi = "Semih";
            musteri1.Soyadi = "Elibol";
            musteri1.DogumTarihi = new DateTime(1986, 01, 25);
            musteri1.Meslegi = "Serbest";
            musteri1.AnneKizlikSoyadi = "Elma";
            musteri1.MusteriNo = "0001";
            musteri1.CepTel = "5555555";
            musteri1.Adres = "Bingöl";
            musteri1.HesapAcilisTarihi = new DateTime(2021, 01, 15);
            musteri1.AktifMi = true;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.TcNo = "22222222222";
            musteri2.Adi = "Melek";
            musteri2.Soyadi = "Elibol";
            musteri2.DogumTarihi = new DateTime(1988, 01, 02);
            musteri2.Meslegi = "Öğretmen";
            musteri2.AnneKizlikSoyadi = "Çilek";
            musteri2.MusteriNo = "0002";
            musteri2.CepTel = "5555555";
            musteri2.Adres = "Bingöl";
            musteri2.HesapAcilisTarihi = new DateTime(2021, 01, 11);
            musteri2.AktifMi = true;

            Musteri[] musteriler = new Musteri[] {
            musteri1,musteri2
            };

            MusteriManager musteriManager = new MusteriManager();
            string tus="0";
            while(tus != "9")
            {
                Console.WriteLine("Müşteri1 Eklemek için..............: '1'");
                Console.WriteLine("Müşteri2 Eklemek için..............: '2'");
                Console.WriteLine("Müşteri1 Güncellemek için..........: '3'");
                Console.WriteLine("Müşteri Güncellemek için...........: '4'");
                Console.WriteLine("Müşteri1 Silemek için..............: '5'");
                Console.WriteLine("Müşteri2 Silemek için..............: '6'");
                Console.WriteLine("Müşterileri Listelemek için........: '7'");
                Console.WriteLine("Silinen Müşterileri Listelemek için: '8'");
                Console.WriteLine("Çıkmak için........................: '9'");
                tus = Console.ReadLine();
                
                switch (tus)
                {
                    case "1": musteriManager.Ekle(musteri1); break;
                    case "2": musteriManager.Ekle(musteri2); break;
                    case "3": musteriManager.Guncelle(musteri1); break;
                    case "4": musteriManager.Guncelle(musteri2); break;
                    case "5": musteriManager.Sil(musteri1); break;
                    case "6": musteriManager.Sil(musteri2); break;
                    case "7": musteriManager.Listele(musteriler); break;
                    case "8": musteriManager.SilinenleriListele(musteriler); break;
                    case "9": Console.WriteLine("Çıkış Yapılıyor...");  break;
                    default: Console.WriteLine("1-9 Arası bir tuşa basın...");  break;
                }

                if (tus!="9")
                {
                    Console.WriteLine("Ekranı Temizlemek için 'Delete' Tuşuna Basın...");
                    if (Console.ReadKey(true).Key == ConsoleKey.Delete)
                    {
                        Console.Clear();
                    }
                }             
                               
            }

            
        }
    }
}
