using System;

Action<string> print = str =>
    Console.WriteLine(str);

static void Print(string str) =>
    Console.WriteLine(str);

print("Jurgen Klopp");
Print("Steven Gerrard");

Func<int, int, int> sum = (num1, num2) => num1 + num2;

Console.WriteLine(sum(12, 7));
Console.WriteLine(Sum(5, 4));

static int Sum(int num1, int num2)
{
    return num1 + num2;
}

Predicate<int> checkEven = number => number % 2 == 0;

static bool CheckEven(int number)
{
    return number % 2 == 0;
}

Console.WriteLine(checkEven(3));
Console.WriteLine(CheckEven(4));


MyPredicate checkEqual = (num1, num2) => num1 == num2;
Console.WriteLine(checkEqual(2, 4));

delegate bool MyPredicate(int num1, int num2);

