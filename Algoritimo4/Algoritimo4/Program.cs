// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("Quanto vai gastar na reforma");
Console.WriteLine("Qual a largura");
double largura, comprimento, area, valorMetro, valorTerreno;
largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Qual o comprimento");
comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Qual o valor do metro quadrado");
valorMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
area = largura * comprimento;
valorTerreno = area * valorMetro;
Console.WriteLine("O valor total é:R$ " + valorTerreno.ToString("F2", CultureInfo.InvariantCulture));

