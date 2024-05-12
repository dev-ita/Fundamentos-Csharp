namespace App.Calculadora;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Calculadora C#";

        Menu();
    }

    public static void Menu()
    {
        short option;
        do
        {
            Console.Clear();
            Console.WriteLine("Calculadora C#");
            Console.Write("Primeiro valor: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Segundo valor: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.Write("1 - Somar\n2 - Subtrair\n3 - Dividir\n4 - Multiplicar\n5 - Sair\n");
            Console.Write("Digite a opção: ");
            option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1: Soma(num1, num2); Console.ReadKey(); break;
                case 2: Subtracao(num1, num2); Console.ReadKey(); break;
                case 3: Divisao(num1, num2); Console.ReadKey(); break;
                case 4: Multiplicacao(num1, num2); Console.ReadKey(); break;
                case 5: Environment.Exit(0); break;
                default: Console.WriteLine("Opção inválida!"); Console.ReadKey(); break;
            }
        } while (option != 5);
    }

    public static double Soma(double num1, double num2)
    {
        double soma = num1 + num2;
        Console.WriteLine($"{num1} + {num2} = {soma}");
        return soma;
    }

    public static double Subtracao(double num1, double num2)
    {
        double subtracao = num1 - num2;
        Console.WriteLine($"{num1} - {num2} = {subtracao}");
        return subtracao;
    }

    public static double Divisao(double num1, double num2)
    {
        double divisao = num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {divisao}");
        return divisao;
    }

    public static double Multiplicacao(double num1, double num2)
    {
        double multiplicacao = num1 * num2;
        Console.WriteLine($"{num1} * {num2} = {multiplicacao}");
        return multiplicacao;
    }
}