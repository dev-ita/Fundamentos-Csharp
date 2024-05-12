Product produto = new Product(1, "Mouse Gamer", 199.50, EProductType.GamerProduct);
Product produto2 = new Product(2, "Manuteção de um Notebook", 500.50, EProductType.Service);

Console.WriteLine(produto);
Console.WriteLine(produto2 + " - " + (int)produto2.ProductType);

enum EProductType
{
    Product = 1,
    Service = 2,
    GamerProduct = 3,
}

struct Product
{
    public int Id;
    public string Name;
    public double Price;
    public EProductType ProductType;

    public Product(int id, string name, double price, EProductType productType)
    {
        Id = id;
        Name = name;
        Price = price;
        ProductType = productType;
    }

    public override string ToString()
    {
        return $"{Id} {Name} {Price} {ProductType}";
    }

    public double ValueInDolar(double dolar)
    {
        return Price / dolar;
    }
}