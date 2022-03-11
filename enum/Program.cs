int satir = 2, sutun=3;
int[,] matrisA = new int[satir, sutun];

Console.WriteLine(gunler.Pazar);
Console.WriteLine((int)gunler.Pazar);

int sicaklik = 2;

if (sicaklik >= (int)HavaDurumu.soguk)
    Console.WriteLine("Hava soğuk");
else if (sicaklik >= (int)HavaDurumu.normal)
{
    Console.WriteLine("Hava sıcaklığı normal");
}
else if(sicaklik >= (int)HavaDurumu.sicak)
{
    Console.WriteLine("Hava sıcak!");
}


enum gunler
{
    Pazartesi = 1,
    Sali,
    Çarsamba,
    Persembe,
    Cuma,
    Cumartesi,
    Pazar
}
enum HavaDurumu
{
    soguk = 5,
    normal = 20,
    sicak = 25,
    cokSicak = 30
}