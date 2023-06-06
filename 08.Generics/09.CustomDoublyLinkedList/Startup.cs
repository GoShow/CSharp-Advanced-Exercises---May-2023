using CustomLinkedList;
using System;

CustomDoublyLinkedList<int> list = new();

list.AddFirst(3);
list.AddFirst(2);
list.AddFirst(1);
list.AddLast(4);

Console.WriteLine(list.RemoveFirst());
Console.WriteLine(list.RemoveLast());

int[] arr = list.ToArray();

list.ForEach(i => Console.Write(i + " "));
Console.WriteLine();
Console.WriteLine(list.Count);

CustomDoublyLinkedList<string> stringList = new();

stringList.AddFirst("some");
stringList.AddFirst("random");
stringList.AddFirst("strings");
stringList.AddLast("added");

stringList.ForEach(i => Console.Write(i + " "));
Console.WriteLine();
Console.WriteLine(stringList.Count);

