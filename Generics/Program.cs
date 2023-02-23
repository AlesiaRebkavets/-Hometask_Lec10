namespace Generics;

public class Program
{
    public static void Main()
    {
        // creating new GenericStorage of <Man> type with array field and adding array elements using constructor without parameters
        GenericStorage<Man> manStorage = GenerateArray<Man>(5);
        Console.WriteLine(
            $"\nArray with five elements, constructor without parameters was used: \n{manStorage.ToStringMethod()}\n");

        // deleting one array element
        manStorage.RemoveElement();

        // adding new element to the array using constructor with parameters
        manStorage.AddElement(new Man("Jesse", "Pinkman"), 4);
        Console.WriteLine($"One element was deleted and Jesse Pinkman was added: \n{manStorage.ToStringMethod()}\n");

        // creating new GenericStorage of <Woman> type with array field and adding array elements using constructor without parameters
        GenericStorage<Woman> womanStorage = GenerateArray<Woman>(2);
        Console.WriteLine(
            $"Array with two elements, constructor without parameters was used: \n{womanStorage.ToStringMethod()}\n");

        // deleting one array element
        womanStorage.RemoveElement();

        // adding new element to the array using constructor with parameters
        womanStorage.AddElement(new Woman("Rachel", "Greene"), 1);
        Console.WriteLine(
            $"One element was deleted and Rachel Greene was added: \n{womanStorage.ToStringMethod()}\n");

        // getting array element value by index
        Console.WriteLine($"Getting array element value by index: {manStorage.GetElement(0)}");
        Console.WriteLine($"Getting array element value by index: {womanStorage.GetElement(1)}\n");


        // getting arrays' length
        Console.WriteLine($"Getting array length: {manStorage.Length()}");
        Console.WriteLine($"Getting array length:  {womanStorage.Length()}\n");
    }

    // method generates GenericStorage<T> elements
    public static GenericStorage<T> GenerateArray<T>(int size) where T : Human, new()
    {
        GenericStorage<T> storage = new GenericStorage<T>(size);


        for (int i = 0; i < size; i++)
        {
            storage.AddElement(new T(), i);
        }

        return storage;
    }
}