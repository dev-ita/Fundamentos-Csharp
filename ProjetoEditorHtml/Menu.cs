using EditorHtml.Util;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();
            try
            {
                var option = Convert.ToInt16(Console.ReadLine());
                HandleMenuOption(option);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        // Handle = manipular
        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Viewer.Show(); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir arquivo");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção:");
        }

        public static void DrawScreen()
        {
            createFullLine();
            for (int lines = 0; lines <= 10; lines++)
            {
                createVoidLine();
            }
            createFullLine();
        }

        public static void createFullLine()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
                Thread.Sleep(10);
            }
            Console.Write("+");
            Console.Write("\n");
        }

        public static void createVoidLine()
        {
            Console.Write("|");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            Console.Write("\n");
        }
    }
}
