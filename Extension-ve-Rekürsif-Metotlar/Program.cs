using System;

namespace Extension_ve_Rekürsif_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rekürsif (öz yinelemeli) metotlar
            //int fak=1;
            //for(int i=1; i<=4; i++)
            //{
            //    fak*=i;
            //}
            //Console.WriteLine(fak);

            //******************************

            islemler instance = new();
            
            Console.WriteLine(instance.fak(3));

            //Extesion metotlar
            /*
            string ad="Muharrem TEKİN";
            bool sonuc=ad.chechkSpaces();

            Console.WriteLine(sonuc);
            if(sonuc)
                Console.WriteLine(ad.RemoveWhiteSpaces());
            
            Console.WriteLine(ad.MakeUpperCase());
            Console.WriteLine(ad.MakeLowerCase());

            int[] dizi={1,3,56,3,44,66,54,23};
            dizi.SortArray();
            dizi.Yazdir();

            Random rnd= new Random();
            int index=rnd.Next(0,dizi.Length);
            dizi[index].IsEvenNumber();
            */
        }
    }

    class islemler
    {
        public int fak(int sayi)
        {
            if(sayi==0)
                return 1;
            else
                return sayi * fak(sayi-1);
        }
    }
/*
    public static class Extension
    {
        public static bool chechkSpaces(this string isim)
        {
            return isim.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string isim)
        {
            string[] dizi= isim.Split(" ");
            return string.Join("_",dizi);
        }

        public static string MakeUpperCase(this string isim)
        {
            return isim.ToUpper();
        }
        public static string MakeLowerCase(this string isim)
        {
            return isim.ToLower();
        }

        public static int[] SortArray(this int[] sayiDizisi)
        {
            Array.Sort(sayiDizisi);
            return sayiDizisi;
        }

        public static void Yazdir(this int[] veri)
        {
            foreach(var sayi in veri)
                Console.WriteLine(sayi);
        }

        public static bool IsEvenNumber(this int sayi)
        {
            return sayi%2 == 0;
        }
    }
    */
}
