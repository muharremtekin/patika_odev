using System;

namespace ödev_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Yaz("------ POZİTİF SAYI GİR! ------\n\n");
                int ArrayIndex;
                Yaz("Kelime sayısı: ");
                ArrayIndex=Convert.ToInt32(Console.ReadLine());//Kelime sayısı
                string[] WordArray = new string[ArrayIndex];

                for (int i = 0; i < WordArray.Length; i++)// diziye elemanları atıyoruz
                {
                    Yaz($"{i+1}. Kelime: ");
                    WordArray[i]=Console.ReadLine();
                }

                Array.Reverse(WordArray);//diziyi ters çevirdik
                ArrayPrint(WordArray);//Diziyi yazdırdık
            }
            catch(ArgumentNullException ex)
            {
                Yaz("Boş değer giremezsin!");
                Yaz(ex.ToString());
            }

            catch(FormatException ex)
            {
                Yaz("Yanlış veri girdiniz.");
                Yaz(ex.ToString());
            }

        }
        static void Yaz(string yazi)
        {
            Console.WriteLine(yazi+"\n");
        }

        static void ArrayPrint(string[] ar)
        {
            Yaz("\n------- ÇIKTI -------- \n");
            foreach (var item in ar)
            {
                Yaz(item);
            }
        }
    }
}
