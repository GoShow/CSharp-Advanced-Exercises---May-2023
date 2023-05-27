using System;

Action<string, string[]> printNamesWithAddedTitle = (title, names) =>
{
    foreach (var name in names)
    {
        Console.WriteLine($"{title} {name}");
    }
};

string[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

printNamesWithAddedTitle("Sir", input);