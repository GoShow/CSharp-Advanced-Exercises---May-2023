using System;
using System.Collections.Generic;

Dictionary<string, Dictionary<string, int>> colorsClothes = new();

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string[] tokens = Console.ReadLine()
        .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);

    string color = tokens[0];

    if (!colorsClothes.ContainsKey(color))
    {
        colorsClothes.Add(color, new Dictionary<string, int>());
    }

    for (int j = 1; j < tokens.Length; j++)
    {
        string currentWear = tokens[j];

        if (!colorsClothes[color].ContainsKey(currentWear))
        {
            colorsClothes[color].Add(currentWear, 0);
        }

        colorsClothes[color][currentWear]++;
    }
}

string[] findParams = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

foreach (var colorClothes in colorsClothes)
{
    Console.WriteLine($"{colorClothes.Key} clothes:");

    foreach (var wearCount in colorClothes.Value)
    {
        string printItem = $"* {wearCount.Key} - {wearCount.Value}";

        if (colorClothes.Key == findParams[0] && wearCount.Key == findParams[1])
        {
            printItem += " (found!)";
        }

        Console.WriteLine(printItem);
    }
}