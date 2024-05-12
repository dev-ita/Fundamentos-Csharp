// Value Types
var x = 10;
var y = x;
y = 469;
Console.WriteLine($"{x}, {y}");

// Reference Types
var array = new string[] { "a", "b", "c" };
var arrayRef = array;
arrayRef[2] = "League of Legends";

foreach (var item in array)
{
    Console.WriteLine(item);
}
Console.WriteLine("------------------");
foreach (var item in arrayRef)
{
    Console.WriteLine(item);
}