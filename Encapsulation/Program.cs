ogrenci instance = new ogrenci();
instance.Ad="Muharrem";
instance.Soyad="TEKİN";
instance.OgrenciNo=1010;
instance.Sinif=6;

instance.ogrenciBilgileriGetir();

instance.sinifYukselt();
instance.ogrenciBilgileriGetir();

ogrenci instance2 = new ogrenci("Deniz","DURMAZ",565,-3);
instance2.ogrenciBilgileriGetir();

class ogrenci
{
    private string ad;
    private string soyad;
    private int ogrenciNo;
    private int sinif;

    public string Ad
    {
        get { return ad; }
        set { ad = value; }
    }

    public string Soyad { get => soyad; set => soyad = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif 
    { 
        get => sinif; 
        set  
        {
            if(value <= 1 )
            {
                Console.WriteLine(" Sınıf 1'den küçük olamaz!");
                sinif = 1;
            }
            else
                sinif = value;
        } 
    }

    public ogrenci(string ad, string soyad, int ogrenciNo, int sinif)
    {
        Ad = ad;
        Soyad = soyad;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }
    public ogrenci() { }

    public void ogrenciBilgileriGetir()
    {
        Console.WriteLine("******** ÖĞRENCİ BİLGİLERİ *********");
        Console.WriteLine($"Öğrenci ad:       {this.Ad}");
        Console.WriteLine($"Öğrenci soyad:    {this.Soyad}");
        Console.WriteLine($"Öğrenci numarası: {this.OgrenciNo}");
        Console.WriteLine($"Öğrenci sınıfı:   {this.Sinif}");
    }
    public void sinifYukselt()
    {
        this.Sinif += 1;
    }
    public void sinifDusur()
    {
        this.Sinif -= 1;
    }
}