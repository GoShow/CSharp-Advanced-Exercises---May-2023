using System;
using System.Collections.Generic;
using System.Linq;

List<int> items = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    int item = int.Parse(Console.ReadLine());

    items.Add(item);
}

int[] indices = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Swap(indices[0], indices[1], items);
Print(items);

static void Swap<T>(int firstIndex, int secondIndex, List<T> items)
{
    T temp = items[firstIndex];
    items[firstIndex] = items[secondIndex];
    items[secondIndex] = temp;
}

static void Print<T>(List<T> items)
{
    foreach (T item in items)
    {
        Console.WriteLine($"{typeof(T)}: {item}");
    }
}

