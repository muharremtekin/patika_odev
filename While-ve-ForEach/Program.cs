using System;

namespace While_ve_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Sayı girin: ");
            int sayi=int.Parse(Console.ReadLine());
            int sayac=0;
            while (sayac<=sayi)
            {
                Console.WriteLine(sayac);
                sayac++;
            }

            char character='a';
            while(character<='z')
            {
                Console.WriteLine(character);
                character++;
            }
            */

            string[] aracMarka={"Ford","Tesla","Renault","Toyota"};

            foreach(var araba in aracMarka)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
