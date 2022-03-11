using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {

            /*HR Challenge
            Console.WriteLine("Bir sayı girin");
            int N=Convert.ToInt32(Console.ReadLine());

            if(N%2==0 && 20<N)
            {
                Console.WriteLine("Not weird");
            }
            else if(N%2==0 && 6<=N && N<=20)
            {
                Console.WriteLine("weird");
            }
            else if(N==2 || N==4)
            {
                Console.WriteLine("Not weird");
            }*/

            
            //***************************************
            string userName="Muharrem";
            int time=DateTime.Now.Hour;

            if(6<=time && time<=12)
                Console.WriteLine("Günaydın :) "+userName);
            else if(time<=18)
                Console.WriteLine("İyi günler :) "+userName);
            else if(time<=22)
                Console.WriteLine("İyi akşamlar :) "+userName);
            else
                Console.WriteLine("İyi geceler :) "+userName);

            //****************************************************

           string sonuc = 6<=time && time<=12 ? "Günaydın "+userName: time<=18 ?"İyi günler "+userName: time<=22 ? "İyi Akşamlar":"iyi geceler";
           Console.WriteLine(sonuc);
        }
    }
}
