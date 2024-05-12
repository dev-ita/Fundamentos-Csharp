using System.Text;

namespace EditorHtml.Util
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("--------------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();
            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("--------------");
            Console.Write(" Deseja salvar o arquivo? (s/n):");
            ConsoleKeyInfo salvar = Console.ReadKey();
            if (salvar.KeyChar == 's')
            {
                Save(file, @"C:\workspace\index.html");
            }
            // Viewer.Show(file.ToString());
        }

        public static void Save(StringBuilder file, string path)
        {
            using (var index = new StreamWriter(path))
            {
                index.Write(file);
            }
        }
    }
}
