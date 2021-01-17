using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            // Veri Kaynağına Ekleme İşi
            Console.WriteLine("---------------------------------");
            Console.WriteLine(musteri.Adi+" "+musteri.Soyadi +" Müşterisi Eklendi...");
            Console.WriteLine("---------------------------------");
        }

        public void Guncelle(Musteri musteri)
        {
            // Veri Kaynağında İlgili Müşteri Bilgilerinin Güncellenme İşi
            Console.WriteLine("---------------------------------");
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + ", Müşteri Bilgileri Güncellendi...");
            Console.WriteLine("---------------------------------");
        }

        public void Sil(Musteri musteri)
        {
            // Veri Kaynağında İlgili Müşteri Bilgilerinin Silinmesi İşi
            musteri.AktifMi = false;// Pasif Yapıldı.
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " Müşterisi Silindi...");
        }

        public void Listele(Musteri[] musteriler)
        {
            //Gelen musterileriler dizisi yazdırılıyor
            Console.WriteLine("Müşteriler");
            Console.WriteLine("-----------------------------");
            int sayac = 0;
            foreach (var musteri in musteriler)
            {   
                if (musteri.AktifMi)
                { 
                    Console.WriteLine("Müşteri No: " + musteri.MusteriNo);
                    Console.WriteLine("Hesap Açılış Tarihi: " + musteri.HesapAcilisTarihi.ToString("dd.MM.yyyy"));
                    Console.WriteLine("Adı Soyadı: "+musteri.Adi+" "+musteri.Soyadi);
                    Console.WriteLine("Tc Kimlik No: "+musteri.TcNo);
                    Console.WriteLine("Doğum Tarihi: " + musteri.DogumTarihi.ToString("dd.MM.yyyy"));
                    Console.WriteLine("Mesleği: " + musteri.Meslegi);
                    Console.WriteLine("Anne Kızlık Soyadı: " + musteri.AnneKizlikSoyadi);
                    Console.WriteLine("Cep Telefonu: " + musteri.CepTel);
                    Console.WriteLine("Adresi: " + musteri.Adres);
                    Console.WriteLine("-------------------------------");
                    sayac++;
                }
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Toplam " + sayac + " Müşteri Listelendi...");
            Console.WriteLine("---------------------------------");
        }

        public void SilinenleriListele(Musteri[] musteriler)
        {
            //Gelen musterileriler dizisi yazdırılıyor
            Console.WriteLine("Silinen Müşteriler");
            Console.WriteLine("---------------------------------");
            int sayac = 0;
            foreach (var musteri in musteriler)
            {
                if (musteri.AktifMi==false)
                {
                    Console.WriteLine("Id: " + musteri.Id);
                    Console.WriteLine("Müşteri No: " + musteri.MusteriNo);
                    Console.WriteLine("Hesap Açılış Tarihi: " + musteri.HesapAcilisTarihi);
                    Console.WriteLine("Adı Soyadı: " + musteri.Adi + " " + musteri.Soyadi);
                    Console.WriteLine("Tc Kimlik No: " + musteri.TcNo);
                    Console.WriteLine("Doğum Tarihi: " + musteri.DogumTarihi);
                    Console.WriteLine("Mesleği: " + musteri.Meslegi);
                    Console.WriteLine("Anne Kızlık Soyadı: " + musteri.AnneKizlikSoyadi);
                    Console.WriteLine("Cep Telefonu: " + musteri.CepTel);
                    Console.WriteLine("Adresi: " + musteri.Adres);
                    Console.WriteLine("---------------------------------");
                    sayac++;
                }
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Toplam " +sayac + " Müşteri Listelendi...");
            Console.WriteLine("---------------------------------");
        }
    }
}
