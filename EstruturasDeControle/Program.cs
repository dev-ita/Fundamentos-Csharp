// if-else

Console.WriteLine("------------------ if -----------------");

int codigo = 469;

if (codigo == 469)
{
    Console.WriteLine("Código aceito");
}
else
{
    Console.WriteLine("Código inválido");
}

// switch
Console.WriteLine("------------------ switch -----------------");

int? diaDaSemana = null;

switch (diaDaSemana)
{
    case 1: Console.WriteLine("Domingo"); break;
    case 2: Console.WriteLine("Segunda"); break;
    case 3: Console.WriteLine("Terça"); break;
    case 4: Console.WriteLine("Quarta"); break;
    case 5: Console.WriteLine("Quinta"); break;
    case 6: Console.WriteLine("Sexta"); break;
    case 7: Console.WriteLine("Sábado"); break;
    default: Console.WriteLine("Dia desconhecido!"); break;
}

// for
Console.WriteLine("------------------ for -----------------");

for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
}

// while
Console.WriteLine("------------------ while -----------------");

int a = 0;
while (a < 10)
{
    Console.WriteLine(a);
    a++;
}

// do while
Console.WriteLine("------------------ do while -----------------");

int? doWhile = null;
do
{
    Console.WriteLine("do while");
} while (doWhile.HasValue);