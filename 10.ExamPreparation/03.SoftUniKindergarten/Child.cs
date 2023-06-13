namespace SoftUniKindergarten;

public class Child
{
    public Child(string firstName, string lastName, int age, string parentName, string contactNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        ParentName = parentName;
        ContactNumber = contactNumber;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string ParentName { get; set; }
    public string ContactNumber { get; set; }

    public override string ToString()
    {
        return $"Child: {FirstName} {LastName}, Age: {Age}, Contact info: {ParentName} - {ContactNumber}";
    }
}
