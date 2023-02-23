namespace Generics;

public class Man : Human
{
    // Constructor without parameters
    public Man() : base("Walter", "White")
    {
    }

    // Constructor with parameters
    public Man(string name, string lastName) : base(name, lastName)
    {
    }
}