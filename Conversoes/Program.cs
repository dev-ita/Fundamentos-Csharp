Console.WriteLine("-------------- Conversões Implícitas --------------");
float valor = 25.8F;
int outro = 25;
valor = outro;
Console.WriteLine(valor);
Console.WriteLine(valor.GetType());

Console.WriteLine("-------------- Conversões Explícitas --------------");
int inteiro = 100;
uint inteiroSemSinal = (uint)inteiro;
uint inteiroSemSinal2 = uint.Parse("100"); // Converte uma string para um tipo
uint inteiroSemSinal3 = Convert.ToUInt32(inteiro); // Convert é uma  utilizada para conversão á vários tipos
Console.WriteLine(inteiroSemSinal);
Console.WriteLine(inteiroSemSinal2);
Console.WriteLine(inteiroSemSinal3);

float real = 25.5f;
//inteiro = Convert.ToInt32(real);
Console.WriteLine(inteiro);
real = inteiro; // Conversão implícita
Console.WriteLine(real);
Console.WriteLine(Convert.ToBoolean(1));