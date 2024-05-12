List<int> fib(int num)
{
    List<int> seq = new List<int>() { 0, 1 };

    for (int i = seq.Count; i < num; i++)
    {
        seq.Add(seq[i - 1] + seq[i - 2]);
    }

    return seq;
}

List<int> seq = fib(20);

Console.Write("[");
seq.ForEach(delegate (int num)
{
    Console.Write(num + ",");
});
Console.Write("]");

Console.ReadLine();