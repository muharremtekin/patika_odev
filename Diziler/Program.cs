using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
        /* 
            Console.Write("dizinin eleman sayısını girin: ");
            int diziUzunlugu=int.Parse(Console.ReadLine());
            int[] sayilar= new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("{0}. elemanı girin: ", i+1);
                sayilar[i]=int.Parse(Console.ReadLine());
            }
            int toplam=0;
            foreach(var say in sayilar)
                toplam+=say;
            Console.WriteLine("Ortalama: "+toplam/diziUzunlugu);
        */

            //hackerrank sorusu

            double[] sayiDizisi={1,2,0,-5,-6};
            double pozitif=0, negatif=0,notr=0;
            foreach (var say in sayiDizisi)
            {
                if (say<0)
                {
                    negatif++;
                }
                else if(say==0)
                {
                    notr++;
                }
                else
                pozitif++;
            }
            Console.WriteLine(pozitif/sayiDizisi.Length);//List uzunluğu arr.Count
            Console.WriteLine(negatif/sayiDizisi.Length);
            Console.WriteLine(notr/sayiDizisi.Length);

        }
    }
}
