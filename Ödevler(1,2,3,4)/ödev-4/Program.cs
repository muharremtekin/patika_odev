using System;

namespace ödev_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                string liste="ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"+"abcçdefgğhiıjklmnoöprsştuüvyz";
                
                Console.Write("Cümle girin : ");
                string text = Console.ReadLine();
                string tempText=text;
                string[] words = tempText.Split(' ');//girilen cümleyi kelimelere ayırıp diziye atar
                WordCount(words); //kelime sayısını yazar
                NumberOfLetters(text, liste); //Harf sayısnı bulur ve yazar
            }
            
            catch(ArgumentNullException ex)
            {
                Print("Boş değer giremezsin!");
                Print(ex.ToString());
            }

            catch(FormatException ex)
            {
                Print("Yanlış veri girdiniz.");
                Print(ex.ToString());
            }

        }

        static void Print(string yazi)
        {
            Console.WriteLine(yazi);
        }
        static void WordCount(string[] txt)//kelime sayısını yazar
        {
            Print($"Kelime Sayısı : {txt.Length}");
        }
        static void NumberOfLetters(string txt, string lst)//harf sayısını hesaplar ve yazar
        {
            int sayac=0;
            for (int i = 0; i < txt.Length; i++)
            {
                if (lst.Contains(txt[i]))
                {
                    sayac++;
                }
            }
            Print($"Harf sayısı: {sayac}");
        }
    }
}
