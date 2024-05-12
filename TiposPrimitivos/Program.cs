// byte
Console.WriteLine("-------------- Bytes --------------");
byte bytes = byte.MaxValue;
sbyte sbytes = sbyte.MinValue;
Console.WriteLine(bytes);
Console.WriteLine(sbytes);

// inteiros
Console.WriteLine("-------------- Inteiros --------------");
int inteiro = int.MinValue;
uint inteiroSemSinal = uint.MinValue;
short inteiroCurto = short.MaxValue;
long inteiroLongo = long.MaxValue;
Console.WriteLine(inteiro);
Console.WriteLine(inteiroSemSinal);
Console.WriteLine(inteiroCurto);
Console.WriteLine(inteiroLongo);

// números reais
Console.WriteLine("-------------- Reais --------------");
float pi = 3.14F; // notação F
double numeroDouble = double.MaxValue;
decimal numeroDecimal = decimal.MaxValue; // notação M
Console.WriteLine(pi);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);
Console.WriteLine(10.5M + 10.5M);

// boleanos
Console.WriteLine("-------------- Boolean --------------");
bool verdadeiro = true;
bool falso = false;
Console.WriteLine(verdadeiro);
Console.WriteLine(falso);

// chars
Console.WriteLine("-------------- Chars --------------");
char letra = 'Í';
Console.WriteLine(letra);

// strings
Console.WriteLine("-------------- Strings --------------");
string texto = "Olá C#";
Console.WriteLine(texto);

// object
Console.WriteLine("-------------- Object --------------");
// O tipo object pode receber qualquer valor ou objeto
object idade = 20;
Console.WriteLine(idade);
idade = "Qualquer coisa";
Console.WriteLine(idade.GetType());

// nullable types
Console.WriteLine("-------------- Nullable Types --------------");
int? nullable = null;

if (nullable.HasValue)
{
    Console.WriteLine(nullable);
}
else
{
    Console.WriteLine("Valor nulo");
}