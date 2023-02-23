namespace Generics;

public class Woman : Human
{
    // Constructor without parameters
    public Woman() : base("Monica", "Geller")
    {
    }

    // Constructor with parameters
    public Woman(string name, string lastName) : base(name, lastName)
    {
    }
}