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
Console.WriteLine("*********ÇALIŞAN 1***********");
personel per1 = new personel();
per1.name = "Muharrem";
per1.surname = "TEKİN";
per1.No = 202151502031;
per1.department="IT";

per1.PersonalInfo();

Console.WriteLine("*********ÇALIŞAN 2***********");

personel per2 = new personel("Can", "Deger",20215223654,"Cyber Security");
per2.PersonalInfo();
Console.WriteLine("**********ÇALIŞAN 3**********");
personel per3 = new personel("Cevat", "Yerli");
per3.PersonalInfo();
class personel
{
    public string name;
    public string surname;
    public long No;
    public string department;

    public personel(string ad, string soyad, long num, string departman)
    {
        this.name = ad;
        this.surname= soyad;
        this.No = num;
        this.department = departman;
    }

        public personel(string ad, string soyad)
    {
        this.name = ad;
        this.surname= soyad;
    }

    public personel(){}

    public void PersonalInfo()
    {
        Console.WriteLine($"Personal name: {name}");
        Console.WriteLine($"Personal surname: {surname}");
        Console.WriteLine($"Personal No: {No}");
        Console.WriteLine($"Personal department: {department}");
    }
}