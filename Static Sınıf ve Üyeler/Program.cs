/*
//mİN CLass
Console.WriteLine($"Çalışan sayısı: {calisan.CalisanSayisi}");
calisan c1 = new calisan("Muharrem", "TEKİN", "IT");
calisan c2 = new calisan("Muharrem", "TEKİN", "IT");
Console.WriteLine($"Çalışan sayısı: {calisan.CalisanSayisi}");
Console.WriteLine(islemler.topla(5564,5656));
Console.WriteLine(islemler.cikar(500,750));
//class
class calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi; }

    private string Ad;
    private string Soyad;
    private string Depatman;

    static calisan()
    {
        calisanSayisi = 0;
    }
    public calisan(string ad, string soyad, string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.Depatman = departman;
        calisanSayisi++;
        Console.WriteLine("Çalışan eklendi.");
    }
}
static class islemler
{
    public static long topla(int s1, int s2)
    {
        return s1 + s2;
    }
    public static long cikar(int s1, int s2)
    {
        return s1 - s2;
    }
}
*/
int n, buyuk, sayi;
Console.Write("Kaç sayı girilecek?:  ");
n = int.Parse(Console.ReadLine());
Console.Write("1. Sayıyı giriniz: ");
sayi = int.Parse(Console.ReadLine());
buyuk = sayi;
for (int i = 1; i < n; i++)
{
    Console.Write($"{i + 1} Sayıyı giriniz: ");
    sayi = int.Parse(Console.ReadLine());
    if (sayi > buyuk)
        buyuk = sayi;
}
Console.WriteLine($"En büyük sayı: {buyuk}");