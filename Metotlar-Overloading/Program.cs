using System;

namespace Metotlar_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi="2222";
            

            bool sonuc = int.TryParse(sayi, out int outsayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outsayi);
            }
            else
            {
                Console.WriteLine("Başarısız.");
            }

            metotlar Nesne = new metotlar();
            Nesne.Toplam(5,6, out int ToplamSonucu);
            Nesne.ekranaYaz(ToplamSonucu);
            Nesne.ekranaYaz("Muharrem"," Tekin");
        }
    }

    class metotlar 
    {
        //metot imzası
        // metot adı + parametre sayısı + parametre
        public void Toplam(int a, int b, out int topSonuc)
        {
            topSonuc=a+b;
        }

        public void ekranaYaz(string veri1, string Veri2)
        {
            Console.WriteLine(veri1+Veri2);
        }
        public void ekranaYaz(int veri)
        {
            Console.WriteLine(veri);
        }
    }
}
