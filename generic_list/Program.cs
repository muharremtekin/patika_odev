using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(33);
            sayilar.Add(332);
            sayilar.Add(122);
            sayilar.Add(32);
            sayilar.Add(56);

            List<string> renkler = new List<string>();
            renkler.Add("Mor");
            renkler.Add("Yeşil");
            renkler.Add("Sarı");
            renkler.Add("Turuncu");
            renkler.Add("Kahverengi");

            Console.WriteLine(sayilar.Count);
            Console.WriteLine(renkler.Count);
            
            
//foreach ve List.ForEach erişimi

            //foreach(var renk in renkler)
              //  Console.WriteLine(renk);
            //foreach(var sayi in sayilar)
              //  Console.WriteLine(sayi);
            renkler.ForEach(renk=> Console.WriteLine(renk));
            sayilar.ForEach(sayi=> Console.WriteLine(sayi));

            //Eleman çıkarma
            sayilar.Remove(3);
            renkler.Remove("Turuncu");

            sayilar.RemoveAt(1);
            renkler.RemoveAt(1);

            renkler.ForEach(renk=> Console.WriteLine(renk));
            sayilar.ForEach(sayi=> Console.WriteLine(sayi));

            //Liste içinde arama

            if(sayilar.Contains(32))
              Console.WriteLine("10 liste içinde bulundu");
            else
              Console.WriteLine("10 Listede yok");
            //Eleman ile index'e erişme
            Console.WriteLine(renkler.BinarySearch("Yeşil"));

            //Diziyi List'e çevirme
            string[] hayvanlar = {"Arı","Papağan","Lemur"};
            List<string> hayvanList = new(hayvanlar);
            hayvanList.ForEach(hayvan=> Console.WriteLine(hayvan));

            //Listeyi temizleme
            hayvanList.Clear();

            //List içerisinde nesne tutmak

            List<kullanicilar> kullaniciListesi = new List<kullanicilar>();

            kullanicilar user1 = new kullanicilar();
            user1.Isim = "Muharrem";
            user1.Soyisim="TEKİN";
            user1.Yas="20";

            kullanicilar user2 = new kullanicilar();
            user2.Isim = "Maria";
            user2.Soyisim="SHARAPOVA";
            user2.Yas="29";

            kullanicilar user3 = new kullanicilar();
            user3.Isim = "Hadise";
            user3.Soyisim="AÇIKGÖZ";
            user3.Yas="30";

            kullaniciListesi.Add(user1);
            kullaniciListesi.Add(user2);
            kullaniciListesi.Add(user3);

            

            List<kullanicilar> newList = new List<kullanicilar>();
            newList.Add( new kullanicilar(){
              Isim="Özlem",
              Soyisim="TEKİN",
              Yas="40"
            });

            foreach (var user in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı: "+user.Isim);
                Console.WriteLine("Kullanıcı Soyadı: "+user.Soyisim);
                Console.WriteLine("Kullanıcı Adı: "+user.Yas);
            }

            /*Generic fonksiyon

                Farklı veri tipindeki dizileri alıp ekrana yazdıran metot

                public static void PrintArray<T>(T[] arr)
                {
                  foreach(var e in arr)
                   Console.WriteLine(e);
                }
            */
        }
    }
    public class kullanicilar
    {
      private string isim;
      
      private string soyisim;

      private string yas;

      public string Isim{get => isim; set => isim = value; }
      public string Yas{get => yas ; set => yas = value; }
      public string Soyisim{get => soyisim ; set => soyisim = value; }
    }
}
