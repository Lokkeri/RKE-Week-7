using System.Numerics;

Console.WriteLine("Enter the operation (+/-):");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("Enter a:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter b:");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case '+':
        addition(firstNum, secondNum);
        break;
    case '-':
        subtraction(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("invalid operator");
        break;
}

static void addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void subtraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}