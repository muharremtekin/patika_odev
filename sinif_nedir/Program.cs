/*
class SinifAdi
{
    [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
    [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler])
    {
        //Metot Gövdesi
    }
}

1. Public : Her yerden erişilebilir.

2. Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.

3. Internal : Sadece bulunduğu proje içerisinden erişilebilir

4. Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.

*/

//Aşağıdaki kodlar aksini belirtmediğim sürece main class içinmdeki main metodun içinde çalışır.
personel per1 = new personel();
per1.name = "Muharrem";
per1.surname = "TEKİN";
per1.No = 202151502031;
per1.department="IT";

per1.PersonalInfo();

Console.WriteLine("********************");

personel per2 = new personel();
per2.name="Can";
per2.surname="DEGER";
per2.No=20215223654;
per2.department="Cyber Security";

per2.PersonalInfo();

class personel
{
    public string name;
    public string surname;
    public long No;
    public string department;

    public void PersonalInfo()
    {
        Console.WriteLine($"Personal name: {name}");
        Console.WriteLine($"Personal surname: {surname}");
        Console.WriteLine($"Personal No: {No}");
        Console.WriteLine($"Personal department: {department}");
    }
}