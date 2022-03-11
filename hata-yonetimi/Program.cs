using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
            Console.WriteLine("Bir sayı girin: ");
            int A=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("girilen sayı: "+A);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata kodu: "+ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("Tamamlandı.");
            }


            //************************************

            
            try
            {
                 //int a = int.Parse(null);
                 //int a=int.Parse("test");
                 int a=int.Parse("-8888888888888888");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil:");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok büyük ya da çok küçük bir değer girdiniz.");
                Console.WriteLine(ex);
            }
        }
    }
}
