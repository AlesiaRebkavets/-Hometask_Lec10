namespace Generics;

public class GenericStorage<T> where T : Human
{
    private static T[] array;

    // GenericStorage<T> class constructor
    public GenericStorage(int size)
    {
        array = new T[size];
    }

    // method adds element to the array
    public T[] AddElement(T element, int index)
    {
        if (index < array.Length)
        {
            array[index] = element;
            return array;
        }
        else if (index == array.Length)
        {
            Array.Resize(ref array, (array.Length + 1));
            array[array.Length - 1] = element;
            return array;
        }
        else
        {
            throw new InvalidOperationException("Invalid index value vas indicated.");
        }
    }

    // method deletes one element from array
    public void RemoveElement()
    {
        if (array.Length == 0)
        {
            throw new InvalidOperationException("Cannot remove an element from an empty array.");
        }
        else
        {
            Array.Resize(ref array, (array.Length - 1));
        }
    }

    // method returns the array element value by index
    public string GetElement(int index)
    {
        T elem = array[index];
        string str = $"{elem.name} {elem.lastName}";
        return str;
    }

    // method returns the array length
    public string Length()
    {
        return array.Length.ToString();
    }

    // method returns all the names and last names from the array and a message indicating if there are only women or only men
    public string ToStringMethod()
    {
        string output = "";
        bool hasWomen = false;
        bool hasMen = false;

        foreach (T item in array)
        {
            if (item == null)
            {
                continue;
            }

            if (item is Woman)
            {
                hasWomen = true;
            }
            else if (item is Man)
            {
                hasMen = true;
            }

            output += $"{item.name} {item.lastName} \n";
        }

        if (hasWomen)
        {
            return output + "There're only women.";
        }
        else if (hasMen)
        {
            return output + "There're only men.";
        }
        else
        {
            return output;
        }
    }
}