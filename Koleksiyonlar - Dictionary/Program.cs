using System.Collections.Generic;

Dictionary<int,string> kullanicilar = new Dictionary<int, string>();
kullanicilar.Add(10,"Muharrem TEKİN");
kullanicilar.Add(14,"Yasin KOÇ");
kullanicilar.Add(24,"İsmail Can DÖRTKARDEŞ");
kullanicilar.Add(32,"Ömer KARATAŞ");
kullanicilar.Add(7,"Özgür EKER");
kullanicilar.Add(5,"Buğra ARKIN");

//Dizinin elemanlarına erişim
Console.WriteLine("******* Elemanlara erişim *******");
Console.WriteLine(kullanicilar[24]);

foreach (var item in kullanicilar)
    Console.WriteLine(item);

//Count
Console.WriteLine("******* Count *******");
Console.WriteLine(kullanicilar.Count);

//Contains
Console.WriteLine("******* Contains *******");
Console.WriteLine(kullanicilar.ContainsKey(5));
Console.WriteLine(kullanicilar.ContainsValue("Muharrem TEKİN"));

//Remove
Console.WriteLine("******* Remove *******");
kullanicilar.Remove(10);
foreach (var item in kullanicilar)
    Console.WriteLine(item);

//Keys
Console.WriteLine("******* Keys *******");
foreach (var item in kullanicilar.Keys)
    Console.WriteLine(item);
//Values
foreach (var item in kullanicilar.Values)
    Console.WriteLine(item);


