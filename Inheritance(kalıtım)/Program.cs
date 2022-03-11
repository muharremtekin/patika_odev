using System;

namespace Inheritance_kalıtım_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                miras alan class ismi : miras alınan class ismi
                örnek; 

                public class hayvanlar:canlılar
                {

                }
            */
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();
            Console.WriteLine("***********************************");
            Surungenler iguana = new Surungenler();
            iguana.SogukKanli();
            iguana.SurunerekHareket();
        }
    }
}
