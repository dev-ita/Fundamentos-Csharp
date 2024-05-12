using System.Text.RegularExpressions;

namespace EditorHtml.Util
{
    public static class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("MODO DE VISUALIZAÇÃO");
            Console.WriteLine("--------------");
            Replace(text);
            Console.ReadKey();
            Menu.Show();
        }

        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("MODO DE VISUALIZAÇÃO");
            Console.WriteLine("--------------");

            using (var file = new StreamReader(@"C:\workspace\index.html"))
            {
                string? fulltext = "";
                while (file.Peek() >= 0)
                {
                    fulltext += file.ReadLine();
                    fulltext += Environment.NewLine;
                }
                Console.WriteLine(fulltext);
                Replace(fulltext);
            }

            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            Regex strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        // <strong>teste</strong>
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (words[i].LastIndexOf('<') - 1) -
                            words[i].IndexOf('>')
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}
