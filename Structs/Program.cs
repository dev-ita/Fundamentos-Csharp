class Program
{
    public static void Main(string[] args)
    {
        Product product = new Product(1, "Mouse Gamer", 199.79);

        Console.WriteLine(product.ToString());
        Console.WriteLine(product.ValueInDolar(5.19).ToString("N2") + "$");
    }
}

struct Product
{
    public int Id;
    public string Name;
    public double Price;

    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Id} {Name} {Price}";
    }

    public double ValueInDolar(double dolar)
    {
        return Price / dolar;
    }
}