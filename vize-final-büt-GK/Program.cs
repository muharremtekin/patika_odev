using System;

namespace vize_final_büt_GK
{
    class Program
    {
        static void Main(string[] args)
        {
            try//hata yönetim blogu
            {
                Console.Write("Vize notu: ");
                double vize=Convert.ToDouble(Console.ReadLine());
                Console.Write("Final notu: ");
                double final=Convert.ToDouble(Console.ReadLine());

                if (vize<=100 && vize>=0 && final>=0 && final<=100)//verilerin işleme uygun olup olmadığını kontrol eder.
                {
                    double ort;
                    ort=vize*0.4 + final*0.6;
                    int s=Convert.ToInt32(ort);
                    
                    if (ort>=50 && final>=50)//Dersten geçtiysen çalışır.
                    {
                        Console.WriteLine($"{ort} ortalama İle GEÇTİNİZ!");
                    }

                    else if(final<50)//büte kaldıysan çalışır.
                    { 
                        Console.Write("Büt notunuzu giriniz: ");
                        double but=double.Parse(Console.ReadLine());
                        double butOrt=vize*0.4+but*0.6;

                        if (butOrt>=50 && but>=50)// büt, final yerine geçer.
                        {
                            Console.WriteLine($"{butOrt} ortalama ile GEÇTİNİZ");
                        }
                        else
                         Console.WriteLine("Seneye denersin :D");
                    }
                }
                else
                Console.WriteLine("Geçersiz veri girdiniz.");
            }//try bitiş

            catch (ArgumentNullException ex)//catch blogu hata alındığı zaman çalışır.
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