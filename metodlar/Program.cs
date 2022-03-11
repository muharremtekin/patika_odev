using System;

namespace metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=5, b=6;
            int sonuc=Topla(a,b);
            yazdir snc = new yazdir();

            snc.ekranaYazdir(Convert.ToString(sonuc));
            int snc2=snc.artirVeTopla(a,b);
            snc.ekranaYazdir(Convert.ToString(snc2));
        }

        static int Topla(int sayi1, int sayi2)
        {
            return (sayi1+sayi2);
        }
    }

    class yazdir
    {
        public void ekranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        
        public int artirVeTopla(int deger1, int deger2)
        {
            deger1+=1;
            deger2+=1;

            return (deger1+deger2);
        }
    }
}
