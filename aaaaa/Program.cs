using System;
using System.Collections;
using System.Collections.Generic;

namespace aaaaa
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Alanı hesaplanacak şeyi seçin  1=Kare, 2=dikdörtgen, 3=üçgen, 4=daire");
            int islem=Convert.ToInt32(Console.ReadLine());

            switch(islem)
            {

            case 1: double kenar1,sonuc;
            Console.Write("1. kenarı gir: ");
            kenar1=Convert.ToDouble(Console.ReadLine());
            sonuc=kenar1*kenar1;
            Console.WriteLine($"Alan: {sonuc}"); break;

            case 2: 
            
            Console.Write("Kısa kenarı girin:");
            double kisaKenar=Convert.ToDouble(Console.ReadLine());
            Console.Write("Uzun kenarı girin:");
            double uzunKenar=Convert.ToDouble(Console.ReadLine());
            double dkSonuc=kisaKenar*uzunKenar;
            Console.WriteLine($"Dikdörtgenin alanı{dkSonuc}");

            ;break;

            case 3:
            Console.Write("Tabanı girin: ");
            double taban=Convert.ToInt32(Console.ReadLine());
            Console.Write("Yükseklik girin: ");
            double yukseklik=Convert.ToInt32(Console.ReadLine());
            double ucgnSnc=(taban*yukseklik)/2;
            Console.WriteLine($"Üçgenin alanı: {ucgnSnc}");
            ; break;

            case 4:
            const double pi=3.14;
            Console.Write("Yarı çapı girin: ");
            double yariCap=Convert.ToDouble(Console.ReadLine());
            double daireSnc=pi*yariCap*yariCap;
            Console.WriteLine($"Dairenin alanı {daireSnc}");
            ; break;

            }
            */

            
            /*
            int sayi, snc=0;
            Console.WriteLine("sayı gir: ");
            sayi=Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<=sayi; i++)
            {
                snc+=i;
            }
            Console.WriteLine($"Sonuç: {snc}");

            Console.Write("Sayi gir: ");
            int tekSnc=0;
            int tekTop=Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<=tekTop; i++)
            {
                if(tekTop%2==1)
                    tekSnc+=i;
            }
            Console.WriteLine($"snc: {tekSnc}");
            */
            int n = int.Parse(Console.ReadLine());
        var phoneBook = new Dictionary<string, string>();
        
        for(int i = 0; i< n; i++)
        {
            string[] arr = Console.ReadLine().Split(' ');
            string name= arr[0];
            string number=arr[1];
            phoneBook.Add(name, number);
        }
        
        string searchName = "";
        while((searchName = Console.ReadLine()) != null)
        {
            if(phoneBook.ContainsKey(searchName))
            {
                Console.WriteLine(searchName+"="+phoneBook[searchName]);
            }
            else
                Console.WriteLine("Not found");
        }
        }
    }
}
