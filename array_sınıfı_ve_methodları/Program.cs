using System;

namespace array_sınıfı_ve_methodları
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //sırasız yazırır
            int[] sayiDizisi={1,23,3,13,43,243,55,4,1};
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("*********** Array.Sort (sıralı) ************");
            Array.Sort(sayiDizisi);
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);
        
            Console.WriteLine("*********** Array.Clerar (belirlenen dizi elemanlarını sıfıra eşitler) ************");
            Array.Clear(sayiDizisi,0,4);
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            //reverse
            Console.WriteLine("*********** Array.reverse  ************");
            Array.Reverse(sayiDizisi);
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            //IndexOf
            Console.WriteLine("*********** Array.IndexOf (elemanın dizideki indexini bulur.) ************");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 243));

            Console.WriteLine("*********** Array.Resize  ************");
            Array.Resize<int>(ref sayiDizisi, 10);
            sayiDizisi[9]=100;
        */
        
        //hackerrank 1
        
        int[] sayilar={3,2,1,3};
        int buyuk=0, sonuc=0;
        
        for (int i = 0; i < sayilar.Length; i++)
        {
            if(buyuk<sayilar[i])
            {
                buyuk=sayilar[i];
            }
        }
        foreach(var item in sayilar)
        {
            if(buyuk==item)
            sonuc++;
        }
        Console.WriteLine($"{sonuc}a ad");
        }

    }
}
