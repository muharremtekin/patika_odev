using System;

namespace ödev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            int diziIndex;//dizi boyutunu belirleyecek
            ekranaYaz("Pozitif bir sayı girin");
            diziIndex=Convert.ToInt32(Console.ReadLine());

            if(diziIndex>0)//Pozitif sayı kontrolü
            {
                int[] sayiDizisi= new int[diziIndex];//n elemanlı boş bir dizi oluşturuluyor
                ekranaYaz("Girdiğiniz sayı kadar eleman girin");

                for (int i = 0; i < sayiDizisi.Length; i++)//döngü ile dizinin elemanları isteniyor
                {
                    ekranaYaz($"{i+1}. Sayı: ");
                    sayiDizisi[i]=int.Parse(Console.ReadLine());
                }

                ekranaYaz("*********************** SONUÇ ***********************");
                CitftSayiYazici(sayiDizisi);//çift sayıları ekrana yazdıran metot çağırılıyor
            }
            else
            ekranaYaz("Lütfen pozitif bir sayı girin.");

            }//try bitişi

            catch(ArgumentNullException ex)
            {
                ekranaYaz("Boş değer giremezsin!");
                ekranaYaz(ex.ToString());
            }

            catch(FormatException ex)
            {
                ekranaYaz("Yanlış veri girdiniz.");
                ekranaYaz(ex.ToString());
            }
            //catch bitişi
        }

        static void ekranaYaz(string veri)
        {
            Console.WriteLine(veri);
        }
        static void CitftSayiYazici(int[] dizi)
        {
            foreach (var item in dizi)
            {
                if(item%2==0)
                {
                    ekranaYaz(Convert.ToString(item));
                }
            }
        }
    }
}
