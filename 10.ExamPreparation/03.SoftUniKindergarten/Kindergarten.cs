using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten;

public class Kindergarten
{
    private string name;
    private int capacity;
    private List<Child> registry;

    public Kindergarten(string name, int capacity)
    {
        Name = name;
        Capacity = capacity;
        Registry = new List<Child>();
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Capacity
    {
        get { return capacity; }
        set { capacity = value; }
    }

    public List<Child> Registry
    {
        get { return registry; }
        set { registry = value; }
    }

    public int ChildrenCount { get { return Registry.Count; } }

    public bool AddChild(Child child)
    {
        if (Registry.Count < Capacity)
        {
            Registry.Add(child);
            return true;
        }

        return false;
    }

    public bool RemoveChild(string childFullName)
    {
        Child child = GetChild(childFullName);

        bool isRemoved = Registry.Remove(child);

        return isRemoved;
    }

    public Child GetChild(string childFullName)
    {
        return Registry.Find(c => childFullName == $"{c.FirstName} {c.LastName}");
    }

    public string RegistryReport()
    {
        IEnumerable<Child> orderedChildren = Registry
            .OrderByDescending(c => c.Age)
            .ThenBy(c => c.LastName)
            .ThenBy(c => c.FirstName);

        StringBuilder sb = new();

        sb.AppendLine($"Registered children in {Name}:");

        foreach (Child child in orderedChildren)
        {
            sb.AppendLine(child.ToString());
        }

        return sb.ToString().TrimEnd();
    }
}
