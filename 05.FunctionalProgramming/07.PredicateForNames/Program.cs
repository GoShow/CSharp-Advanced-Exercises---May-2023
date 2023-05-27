using System;

Action<string[], Predicate<string>> print = (names, match) =>
{
    foreach (var name in names)
    {
        if (match(name))
        {
            Console.WriteLine(name);
        }
    }
};

int length = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

//Predicate<string> validateNameLength = name =>
//    name.Length <= length;

print(names, n => n.Length <= length);
