
using ConsoleApp1;

People people = new();

while (true)
{
    Console.WriteLine("Select an option:");
    Console.WriteLine("0 - Cancell operation");
    Console.WriteLine("1 - Add data to the list");
    Console.WriteLine("2 - Change item of the list");
    Console.WriteLine("3 - Print the length of the list");
    Console.WriteLine("4 - Remove list's element at specific index");
    Console.WriteLine("5 - Clear the list");
    Console.WriteLine("6 - Display element at specific index");
    Console.WriteLine("7 - Display elements of the list");
    Console.WriteLine();
    int input = int.Parse(Console.ReadLine());
    if (input == 0)
    {
        Console.WriteLine("--Operation cancelled--");
        break;
    }
    else if (input == 1)
    {
        Console.Write("Inform the name: ");
        string Name = Console.ReadLine();
        Console.Write("Inform the age: ");
        int Age = int.Parse(Console.ReadLine());
        Console.Write("Inform the id: ");
        
        int Id = int.Parse(Console.ReadLine());
        people.AddData(Name, Age, Id);
        Console.WriteLine();
    }
    else if (input == 2)
    {
        try
        {
            Console.Write("Inform a valid index: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine();
            people.ChangeElement(index);
            Console.WriteLine();
        }
        catch (Exception)
        {
            Console.WriteLine($"Inform an index between from 0 to {people.SizeList()}");
            Console.WriteLine();
        }
    }
    else if (input == 3)
    {
        Console.WriteLine($"The length of the list is {people.SizeList()}");
        Console.WriteLine();
    }
    else if (input == 4)
    {
        try
        {
            Console.Write("Inform a valid index: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine();
            people.RemoveDataAt(index);
            Console.WriteLine();
        }
        catch (Exception)
        {
            Console.WriteLine($"Inform an index between from 0 to {people.SizeList()}");
            Console.WriteLine();
        }
    }
    else if (input == 5)
    {
        people.ClearList();
    }
    else if (input == 6)
    {
        try
        {
            Console.Write("Inform a valid index: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine();
            people.DisplayDataAt(index);
            Console.WriteLine();
        }
        catch (Exception)
        {
            Console.WriteLine($"Inform an index between from 0 to {people.SizeList()}");
            Console.WriteLine();
        }
    }
    else if (input == 7)
    {
        people.DisplayData();
    }
}
