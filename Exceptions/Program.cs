// Tratamento de erros
// #A0187 Try-Catch

var arr = new int[3] { 1, 2, 3 };

try
{
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine(arr[i]);
    }
    Salvar("");
}
catch (IndexOutOfRangeException err)
{
    Console.WriteLine(err.InnerException);
    Console.WriteLine(err.Message);
    Console.WriteLine("Index não encontrado no Array");
}
catch (ArgumentNullException err)
{
    Console.WriteLine(err.InnerException);
    Console.WriteLine(err.Message);
    Console.WriteLine("Falha ao salvar texto");
}
catch (MyException err)
{
    Console.WriteLine(err.InnerException);
    Console.WriteLine(err.Message);
    Console.WriteLine("Exceção aconteceu as: " + err.QuandoAconteceu);
    Console.WriteLine("Exceção customizada");
}
catch (Exception err) // catch genérico
{
    Console.WriteLine(err.InnerException);
    Console.WriteLine(err.Message);
    Console.WriteLine("Ops, algo deu errado!");
}
finally
{
    Console.WriteLine("Chegou ao fim..");
}

static void Salvar(string? texto)
{
    if (string.IsNullOrEmpty(texto))
    {
        throw new MyException(DateTime.Now);
    }
}

class MyException : Exception
{
    public DateTime QuandoAconteceu { get; set; }
    public new string Message;
    public MyException(DateTime date)
    {
        QuandoAconteceu = date;
        Message = "Aconteceu uma exceção customizada";
    }
}
