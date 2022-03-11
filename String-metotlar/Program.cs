using System;

namespace String_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string degisken="Ben böyle güzzelim";
            string degisken2=" güzzelim";

            //Contact
            Console.WriteLine(string.Concat(degisken," Falan filaaan"));

            //Compare - CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2));//-1,0,1
            Console.WriteLine(String.Compare(degisken,degisken2,true));
            Console.WriteLine(String.Compare(degisken,degisken2,false));

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("güzzelim"));
            Console.WriteLine(degisken.StartsWith("al"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("güz"));
            Console.WriteLine(degisken.IndexOf("maNga"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"maNga: "));

            //PadLeft and PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(35,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

            //Remove
            Console.WriteLine(degisken.Remove(5));
            Console.WriteLine(degisken.Remove(5,8));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("güzzelim","GÜZELİM"));
            Console.WriteLine(degisken.Replace(" ","_"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,8));
            */
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N ; i++)
            {
                string S = Console.ReadLine();
                Solution(S);
            }
        }

        static void Solution(string sa)
        {
            string tek = "";
            string cift = "";

            for(int i = 0; i < sa.Length; i++)
            {
                if(i % 2 == 0)
                {
                    cift+=sa[i];
                }
                else
                    tek+=sa[i];
            }
            Console.WriteLine($"{cift} {tek}");
        }
        
    }
    
}
