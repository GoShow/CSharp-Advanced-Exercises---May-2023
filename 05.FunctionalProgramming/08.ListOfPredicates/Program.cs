using System;
using System.Collections.Generic;
using System.Linq;

List<Predicate<int>> predicates = new();

int endRange = int.Parse(Console.ReadLine());

HashSet<int> dividers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToHashSet();

int[] numbers = Enumerable.Range(1, endRange).ToArray();

foreach (var divider in dividers)
{
    //Predicate<int> checkDivisible = n =>
    //    n % divider == 0;

    predicates.Add(n => n % divider == 0);
}

foreach (var number in numbers)
{
    bool isDivisible = true;

    foreach (var match in predicates)
    {
        if (!match(number))
        {
            isDivisible = false;
            break;
        }
    }

    if (isDivisible)
    {
        Console.Write($"{number} ");
    }
}