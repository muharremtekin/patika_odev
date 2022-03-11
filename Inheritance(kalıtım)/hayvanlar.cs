using System;

namespace Inheritance_kalıtım_
{
    public class hayvanlar : canlılar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adapte olabilir.");
        }
        protected void EseyliUreme()
        {
            Console.WriteLine("Hayvanlar eşeyli ürer.");
        }
        protected void Hareket()
        {
            Console.WriteLine("Hayvanlar hareket eder.");
        }
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir");
        }
    }
    class Surungenler : hayvanlar
    {
        public Surungenler()sdfgsdfgdsfgdsfg
        {
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
            base.Adaptasyon();
            base.EseyliUreme();
            base.Hareket();
        }
        public void SurunerekHareket()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
        public void SogukKanli()
        {
            Console.WriteLine("Sürüngenler soguk kanlıdır.");
        }
    }
    class Kuslar : hayvanlar
    {
        public Kuslar()
        {
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
            base.Adaptasyon();
            base.EseyliUreme();
            base.Hareket();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar");
        }
    }
}