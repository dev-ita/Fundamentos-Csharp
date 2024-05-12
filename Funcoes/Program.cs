string ReverseWord(string word)
{
    char[] charArray = word.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

List<int> FibSeq(int len = 20)
{
    List<int> seq = new List<int>() { 0, 1 };
    for (int i = seq.Count; i < len; i++)
    {
        seq.Add(seq[i - 1] + seq[i - 2]);
    }
    return seq;
}

List<int> seq = FibSeq(10);
int maxValue = seq.Max();
Console.WriteLine($"O maior valor da sequência gerada é: {maxValue}");
seq.ForEach(delegate (int num)
{
    Console.Write(num + ",");
});
Console.WriteLine();

string r = ReverseWord("italo");
Console.WriteLine(r);