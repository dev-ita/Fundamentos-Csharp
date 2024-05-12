// guides - Global Unique Identifier
using System.Text;

Guid id = Guid.NewGuid();
Console.WriteLine(id.ToString().Substring(0, 8));
Console.WriteLine(id);

// interpolação de strings
//#A0141
Console.WriteLine("------- Interpolação -------");
var price = 10.2;
var texto = $@"O preço do produto
é: {price}$";
Console.WriteLine(texto);

// Comparação de strings
Console.WriteLine("------- Comparação -------");
string text2 = "testando";
Console.WriteLine(text2.CompareTo("testando"));
Console.WriteLine(text2.CompareTo("Testando"));
Console.WriteLine(text2.Contains("testando"));
Console.WriteLine(text2.Contains("Testando", StringComparison.OrdinalIgnoreCase));

// StartsWith e EndsWith
Console.WriteLine("------- StartsWith e EndsWith -------");
string nome = "Ítalo Oliveira";
Console.WriteLine(nome.StartsWith("Ítalo"));
Console.WriteLine(nome.StartsWith("ítalo", StringComparison.OrdinalIgnoreCase));
Console.WriteLine(nome.EndsWith("Oliveira"));

// Equals
Console.WriteLine("------- Equals -------");
var text = "Este é um texto teste";
var num = 10;
Console.WriteLine(num.Equals(110));
Console.WriteLine(text.Equals("Este é um texto teste"));
Console.WriteLine(text.Equals("este é um texto teste"));

// Indices
Console.WriteLine("------- Indices -------");
Console.WriteLine(text.IndexOf("s"));
Console.WriteLine(text.LastIndexOf("s"));

// Métodos adicionais
Console.WriteLine("------- Métodos Adicionais -------");
Console.WriteLine(text.ToLower());
Console.WriteLine(text.ToUpper());
Console.WriteLine(text.Insert(5, "AQUI "));
Console.WriteLine(text.Remove(5, 5));
Console.WriteLine(text.Length);
Console.WriteLine(text);

// Manipulando strings
Console.WriteLine("------- Manipulando Strings -------");
Console.WriteLine(text.Replace("Este", "Isto"));
Console.WriteLine(text.Replace("e", "x"));
var divisao = text.Split(" ");
Console.Write("[");
foreach (var item in divisao)
{
    Console.Write($"{item},");
}
Console.Write("]");
Console.WriteLine();
var resultado = text.Substring(10, 5);
Console.WriteLine(resultado);
var trim = " Qualquer coisa ";
Console.WriteLine(trim.Trim());

// StringBuilder (reference type)
Console.WriteLine("------- StringBuilder -------");
var sb = new StringBuilder();
sb.AppendLine("Hello StringBuilder");
Console.WriteLine(sb);

var sb2 = sb;
sb2.AppendLine("Estudando .NET");
Console.WriteLine(sb);

// #A0151