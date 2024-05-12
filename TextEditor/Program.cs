namespace App.TextEditor;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("1 - Abrir arquivo");
        Console.WriteLine("2 - Criar arquivo");
        Console.WriteLine("0 - Sair");
        Console.Write("Digite: ");
        short option = Convert.ToInt16(Console.ReadLine());

        switch (option)
        {
            case 1: Abrir(); break;
            case 2: Editar(); break;
            case 0: Environment.Exit(0); break;
            default: Console.WriteLine("Opção inválida!"); Menu(); break;
        }
    }

    static void Abrir()
    {
        Console.Clear();
        Console.WriteLine("Qual caminho do arquivo?");
        string? path = Console.ReadLine();
        if (path != null)
        {
            using (var file = new StreamReader(path))
            {
                // string text = file.ReadToEnd();
                while (file.Peek() >= 0)
                {
                    Console.WriteLine(file.ReadLine());
                }
                // Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }
    }
    static void Editar()
    {
        Console.Clear();
        Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
        Console.WriteLine("----------------------------");
        string text = "";
        do
        {
            text += Console.ReadLine();
            text += Environment.NewLine;
        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Salvar(text);
    }

    static void Salvar(string text)
    {
        Console.Clear();
        Console.WriteLine("Qual caminho para salvar o arquivo?");
        string? path = Console.ReadLine();
        Console.ReadLine();
        if (path != null)
        {
            // tdo objeto criado dentro de um using é aberto e fechado automaticamente
            // Stream = fluxo, Writer = Escritor
            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }
    }
}