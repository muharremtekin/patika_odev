using System;

namespace ödev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            int ArrayIndex,section;//kontrol edilecek sayıların sayısı ve 
            ekranaYaz("Lütfen sadece pozitif sayıları kullanın. \n\n");
            ekranaYaz("Kaç tane sayı kontrol edilecek? \n Cevap: ");
            ArrayIndex=Convert.ToInt32(Console.ReadLine());
            ekranaYaz("Bölüm: ");
            section=Convert.ToInt32(Console.ReadLine());


            if(ArrayIndex>0 && section>0)//Pozitif sayı kontrolü
            {
                int[] sayiDizisi= new int[ArrayIndex];//n elemanlı boş bir dizi oluşturuluyor
                ekranaYaz("Girdiğiniz sayı kadar eleman girin");

                for (int i = 0; i < sayiDizisi.Length; i++)//döngü ile dizinin elemanları isteniyor
                {
                    ekranaYaz($"{i+1}. Sayı: ");
                    sayiDizisi[i]=int.Parse(Console.ReadLine());
                }

                ekranaYaz("*********************** SONUÇ ***********************");
                CitftSayiYazici(sayiDizisi,section);//çift sayıları ekrana yazdıran metot çağırılıyor
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

        }
        static void ekranaYaz(string veri)
        {
            Console.WriteLine(veri);
        }
        static void CitftSayiYazici(int[] dizi, int sec)
        {
            foreach (var item in dizi)
            {
                if(item%sec==0)
                {
                    ekranaYaz(Convert.ToString(item));
                }
            }
        }

    }
}
