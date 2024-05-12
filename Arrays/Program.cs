// Arrays - #A0181
var meuArray = new int[5] { 5, 4, 3, 2, 1 };
var arrayStructs = new Funcionario[2] { new Funcionario(1, "Ítalo"), new Funcionario() { Id = 2579, Nome = "Isabele" } };

Array.Sort(meuArray);
meuArray[0] = 469;

for (int i = 0; i < meuArray.Length; i++)
{
    Console.WriteLine(meuArray[i]);
}

Console.WriteLine("-------------------");

foreach (var item in arrayStructs)
{
    Console.WriteLine($"index={Array.IndexOf(arrayStructs, item)} id={item.Id} nome={item.Nome}");
}

Console.WriteLine("-------------------");
var arr = new int[4];
var arrb = (int[])arr.Clone();

arr[0] = 369;
arr[1] = 555;
arrb[0] = 469;
arrb[1] = 333;

// arr.CopyTo(arrb, 0);

foreach (var item in arrb)
{
    Console.WriteLine(item);
}

// -------------------
struct Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public Funcionario(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }
}