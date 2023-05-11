using System;
using System.Collections.Generic;
using System.Linq;

Stack<int> clothes = new(
    Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse));

int rackSize = int.Parse(Console.ReadLine());

int currentRackSize = rackSize;
int numberOfRacks = 1;

while (clothes.Any())
{
    currentRackSize -= clothes.Peek();

    if (currentRackSize < 0)
    {
        currentRackSize = rackSize;
        numberOfRacks++;

        continue;
    }

    clothes.Pop();
}

Console.WriteLine(numberOfRacks);

