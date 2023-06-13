using System;
using System.Collections.Generic;
using System.Linq;

Dictionary<int, string> healingItems = new()
{
    { 30, "Patch" },
    { 40, "Bandage" },
    { 100, "MedKit" }
};

SortedDictionary<string, int> createdItems = new();

Queue<int> textiles = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Stack<int> medicaments = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

while (textiles.Any() && medicaments.Any())
{
    int textile = textiles.Dequeue();
    int medicament = medicaments.Pop();
    int sum = textile + medicament;

    if (healingItems.ContainsKey(sum))
    {
        string healingItem = healingItems[sum];

        if (!createdItems.ContainsKey(healingItem))
        {
            createdItems.Add(healingItem, 0);
        }

        createdItems[healingItem]++;
    }
    else if (sum > 100)
    {
        if (!createdItems.ContainsKey("MedKit"))
        {
            createdItems.Add("MedKit", 0);
        }

        createdItems["MedKit"]++;

        int nextMedicament = medicaments.Pop() + (sum - 100);
        medicaments.Push(nextMedicament);
    }
    else
    {
        medicament += 10;
        medicaments.Push(medicament);
    }
}

if (!textiles.Any() && !medicaments.Any())
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if (!textiles.Any())
{
    Console.WriteLine("Textiles are empty.");
}
else
{
    Console.WriteLine("Medicaments are empty.");
}

foreach (var item in createdItems.OrderByDescending(ci => ci.Value))
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

if (textiles.Any())
{
    Console.WriteLine($"Textiles left: {string.Join(", ", textiles)}");
}

if (medicaments.Any())
{
    Console.WriteLine($"Medicaments left: {string.Join(", ", medicaments)}");
}