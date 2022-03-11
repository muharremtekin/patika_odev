using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sayi; i++)
            {
                if (i%2==1)
                {
                    Console.WriteLine(""+i);
                }
            }
            
            // 1'den 1000'e kadar olan sayılarda tek ve çift olanları ayrı ayrı toplar.
            int tekTop=0, ciftTop=0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i%2==1)
                {
                    tekTop+=i;
                }
                else if(i%2==0)
                {
                    ciftTop+=i;
                }
            }
            Console.WriteLine("Tek sayıların toplamı: "+tekTop+"  Çift sayıların toplamı: "+ciftTop);
            

            Console.WriteLine("SAyı girin:");
            int N=Convert.ToInt32(Console.ReadLine());
            int carpim;
            for (int i = 1; i <= 10; i++)
            {
                carpim=N*i;
                Console.WriteLine(N+"."+i+" = "+carpim);
            }
*/

            Console.Write("Sayı girin");
            int sayi=Convert.ToInt32(Console.ReadLine());
            int x,y,z, bosSay=sayi;
            string kare="#",space=" ";

            for (x = 1; x <= sayi; x++)
            {
                for (z=1;z<bosSay;z++)
                {
                    Console.Write(space);
                }
                bosSay=bosSay-1;
                for (y=1; y<=x; y++)
                {
                    Console.Write(kare);
                }
                Console.WriteLine("");
            }
        }
    }
}
