using System;

namespace SoftUniKindergarten;

public class StartUp
{
    static void Main(string[] args)
    {
        Kindergarten kindergarten = new Kindergarten("Space S", 8);

        Child childOne = new Child("Greta", "Garbo", 3, "Karl Gustafsson", "0468 888 888");
        Child childTwo = new Child("Elona", "Muskova", 4, "Maye Musk", " 1 888 518 3752");
        Child childThree = new Child("George", "Bush", 5, " George Bush Sr.", "xx xxx xxxxxx");
        Child childFour = new Child("Ruzha", "Ignatova", 6, "Veska Ignatova", "+49 30901820");
        Child childFive = new Child("Greta", "Thinberg", 3, "Allen White", "541-754-3010");
        Child childSix = new Child("T", "Rex", 2, "Steven Spielberg", "63 001 09 93");
        Child childSeven = new Child("S", "Rex", 2, " Steven Spielberg ", "63 001 09 93");
        Child childEight = new Child("Greta", "Thunberg", 3, "Pablo Gaviria", "0888 888888");
        Child childNine = new Child("Tim", "Duncan", 6, "William Duncan", "(555) 555-1234");

        Console.WriteLine(kindergarten.AddChild(childOne));
        // True
        Console.WriteLine(kindergarten.AddChild(childTwo));
        // True
        Console.WriteLine(kindergarten.AddChild(childThree));
        // True
        Console.WriteLine(kindergarten.AddChild(childFour));
        // True
        Console.WriteLine(kindergarten.AddChild(childFive));
        // True
        Console.WriteLine(kindergarten.AddChild(childSix));
        // True
        Console.WriteLine(kindergarten.AddChild(childSeven));
        // True
        Console.WriteLine(kindergarten.AddChild(childEight));
        // True
        Console.WriteLine(kindergarten.AddChild(childNine));
        // False
        Console.WriteLine(kindergarten.RemoveChild("Ruzha Ignatova"));
        // True
        Console.WriteLine(kindergarten.RemoveChild("George Bush"));
        // True
        Console.WriteLine(kindergarten.RemoveChild("Elona Muskova"));
        // True
        Console.WriteLine(kindergarten.RemoveChild("Ruzha Ignatova"));
        // False
        Console.WriteLine(kindergarten.RemoveChild("Tim Duncan"));
        // False

        Console.WriteLine(kindergarten.ChildrenCount);
        // 5

        Console.WriteLine(kindergarten.GetChild("S Rex"));
        //Child: S Rex, Age: 2, Contact info: Steven Spielberg - 63 001 09 93

        Console.WriteLine(kindergarten.RegistryReport());
        //Registered children in Space S:
        //Child: Greta Garbo, Age: 3, Contact info: Karl Gustafsson - 0468 888 888
        //Child: Greta Thinberg, Age: 3, Contact info: Allen White - 541-754-3010
        //Child: Greta Thunberg, Age: 3, Contact info: Pablo Gaviria - 0888 888 888
        //Child: S Rex, Age: 2, Contact info: Steven Spielberg - 63 001 09 93
        //Child: T Rex, Age: 2, Contact info: Steven Spielberg - 63 001 09 93
    }
}