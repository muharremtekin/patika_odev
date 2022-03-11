using System.Collections;
using System.Collections.Generic;
// See https://aka.ms/new-console-template for more information

//System.Collections namespace

ArrayList liste = new ArrayList();
/*
liste.Add(23);
liste.Add('A');
liste.Add(false);
liste.Add("Tekin");

Console.WriteLine(liste[1]);

foreach (var item in liste)
{
    Console.WriteLine(item);
}
*/
Console.WriteLine("******** Add Range ********");
//string[] renkler = {"Sarı","Mavi","Kırmızı","Mor"};
List<int> sayilar = new List<int>(){1,2,3,4,5,23,21,455,75,43};
//liste.AddRange(renkler);
liste.AddRange(sayilar);

foreach (var item in liste)
{
    Console.WriteLine(item);
}

//Sort
Console.WriteLine("****** Sort (sıralama) ******");
liste.Sort();
foreach (var item in liste)
    Console.WriteLine(item);

//Binary Search
Console.WriteLine("****** Binary Search ******");
Console.WriteLine(liste.BinarySearch(3));

//Reverse
Console.WriteLine("****** Reverse ******");
liste.Reverse();

foreach (var item in liste)
    Console.WriteLine(item);

//Clear
Console.WriteLine("****** Clear ******");
liste.Clear();

foreach (var item in liste)
    Console.WriteLine(item);