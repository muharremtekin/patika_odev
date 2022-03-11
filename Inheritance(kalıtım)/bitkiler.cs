using System;

namespace Inheritance_kalıtım_
{
    public class bitkiler : canlılar
    {
        protected void Fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler güneşe tepki verir.");
        }
    }

    class TohumluBitkiler : bitkiler
    {
        public TohumluBitkiler()
        {
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
            base.Fotosentez();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumla çoğalan bitkiler.");
        }
    }
    class TohumsuzBitkiler : bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
            base.Fotosentez();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumla çoğalan bitkiler");
        }
    }
}