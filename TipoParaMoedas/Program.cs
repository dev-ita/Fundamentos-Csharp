using System.Globalization;

// Formatação
decimal moeda = 5123.12m;
var culture = CultureInfo.CreateSpecificCulture("pt-BR");
Console.WriteLine($"{moeda.ToString("C", culture)}");
Console.WriteLine($"{moeda:C}");

// Math
decimal valor = 10536.25m;
Console.WriteLine(valor);
Console.WriteLine(Math.Round(valor));
// Arredonda para cima^^
Console.WriteLine(Math.Ceiling(valor));
// Arredonda para baixo
Console.WriteLine(Math.Floor(valor));

