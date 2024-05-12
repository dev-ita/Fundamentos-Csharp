double Math(double num1, double num2, char type)
{
    switch (type)
    {
        case '+':
            return num1 + num2;
        case '-':
            return num1 - num2;
        case '*':
            return num1 * num2;
        case '/':
            return num1 / num2;
    }
    return 0.0;
}

int num1 = 10;
int num2 = 10;
int sum = num1 + num2;

Console.WriteLine(sum);
double teste = Math(10, 10, '*');
teste *= 2;
Console.WriteLine(teste);
Console.WriteLine(Math(10, 10, '*'));