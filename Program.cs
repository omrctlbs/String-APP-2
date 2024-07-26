using System;

string kursadi = ".NET 7 ile C# Programlama Dili";
Console.WriteLine(kursadi);
Console.WriteLine();

var kursadilength = kursadi.Length;
Console.WriteLine("Karakter sayısı: " + kursadilength);
Console.WriteLine();

var kursadilower = kursadi.ToLower();
Console.WriteLine("Küçük harflerle yazılımı bu şekilde : " + kursadilower);
Console.WriteLine();

var kursadistart = kursadi.StartsWith('.');
if (kursadistart = true )
{
	Console.WriteLine("Kursadi . ile başlamaktadır. ");
}
else
{
    Console.WriteLine("Kursadi . ile başlamamaktadır.");
}
Console.WriteLine();

var kursadiindex = kursadi.IndexOf("C#");
Console.WriteLine("Cümlede C# konumu : " + kursadiindex);
Console.WriteLine();

var kursadiconst = kursadi.Contains("C#");
if (kursadiconst = true)
{
	Console.WriteLine("Cümlede C# vardır ");
}
else
{
	Console.WriteLine("\"Cümlede C# yoktur");
}
Console.WriteLine();

var kursadireplace = kursadi.Replace("Dili", "Dersleri");
Console.WriteLine(kursadireplace);

