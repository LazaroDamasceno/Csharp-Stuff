using Generics;

static void Options1()
{
    Console.WriteLine("\nGeneric classes require the user to set their type.");
    Console.WriteLine("Type one of the available types:");
    Console.WriteLine("0 - Exit loop");
    Console.WriteLine("1 - Integer");
    Console.WriteLine("2 - Double");
    Console.WriteLine("3 - String");
}

static void Options2()
{
    Console.WriteLine("\nType one of the available options:");
    Console.WriteLine("0 - Return to the initial options");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - ArrayLength");
    Console.WriteLine("3 - CheckEquality");
    Console.WriteLine("4 - DisplayElements");
    Console.WriteLine("5 - ElementAt");
    Console.WriteLine("6 - MaxElement");
    Console.WriteLine("7 - MinElement");
    Console.WriteLine("8 - NumberSpecificElement");
    Console.WriteLine("9 - PrintFromTo");
    Console.WriteLine("10 - ReplaceAt");
    Console.WriteLine("11 - Resize");
    Console.WriteLine("12 - Swap");
}

static void Message()
{
    Console.WriteLine("\nType an option from 0 to 12. 0 takes you back to the initial options.\n");
}

while (true)
{
    Options1();

    Console.WriteLine("\nType an option from 0 to 3. 0 will break the break the loop.\n");
    int type = int.Parse(Console.ReadLine());
    
    if (type == 1)
    {
        var collection = new GenericCollection<int>();
        while (true)
        {
            Options2();
            Message();
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.Write("\nInform an input to be added to collection: ");
                int input = int.Parse(Console.ReadLine());
                collection.Add(input);
            }
            if (option == 2)
            {
                Console.WriteLine(collection.ArrayLength());
            }
            if (option == 3)
            {
                Console.WriteLine("\nInform two integers.\n");
                Console.Write("First integer: ");
                int index1 = int.Parse(Console.ReadLine());
                Console.Write("Second integer: ");
                int index2 = int.Parse(Console.ReadLine());
                Console.WriteLine(collection.CheckEquality(index1, index2));
            }
            if (option == 4)
            {
                collection.DisplayElements();
            }
            if (option == 5)
            {
                Console.Write("\nInform an index: ");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine(collection.ElementAt(index));
            }
            if (option == 6)
            {
                Console.WriteLine(collection.MaxElement());
            }
            if (option == 7)
            {
                Console.WriteLine(collection.MinElement());
            }
            if (option == 8)
            {
                Console.Write("\nInform an input: ");
                int element = int.Parse(Console.ReadLine());
                Console.WriteLine(collection.NumberSpecificElements(element));
            }
            if (option == 9)
            {
                Console.WriteLine("\nInform two integers.");
                Console.WriteLine("The first represents the first element of the sequence.");
                Console.WriteLine("The second represents the last element of the sequence.\n");
                Console.Write("The first index is: ");
                int first = int.Parse(Console.ReadLine());
                Console.Write("The last index is: ");
                int last = int.Parse(Console.ReadLine());
                collection.PrintFromTo(first, last);
            }
            if (option == 10)
            {
                Console.WriteLine("\nInform an index and an element.\n");
                Console.Write("The index: ");
                int index = int.Parse(Console.ReadLine());
                Console.Write("The element: ");
                byte element = byte.Parse(Console.ReadLine());
                collection.ReplaceAt(index, element);
            }
            if (option == 11)
            {
                Console.WriteLine("\nInform the newest size of the array.");
                Console.WriteLine("The new size must be bigger than the current one.\n");
                Console.Write("The newest size: ");
                int newSize = int.Parse(Console.ReadLine()); ;
                collection.Resize(newSize);
            }
            if (option == 12)
            {
                Console.WriteLine("\nInform two integers.");
                Console.Write("First index: ");
                int index1 = int.Parse(Console.ReadLine());
                Console.Write("Second index: ");
                int index2 = int.Parse(Console.ReadLine());
                collection.Swap(index1, index2);
            }
            if (option == 0)
            {
                break;
            }
        }
    }

    else if (type == 2)
    {
        var collection = new GenericCollection<double>();
        while (true)
        {
            Options2();
            Message();
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.Write("\nInform an input to be added to collection: ");
                double input = double.Parse(Console.ReadLine());
                collection.Add(input);
            }
            if (option == 2)
            {
                collection.ArrayLength();
            }
            if (option == 3)
            {
                Console.WriteLine("\nInform two integers.\n");
                Console.Write("First integer: ");
                int index1 = int.Parse(Console.ReadLine());
                Console.Write("Second integer: ");
                int index2 = int.Parse(Console.ReadLine());
                Console.WriteLine(collection.CheckEquality(index1, index2));
            }
            if (option == 4)
            {
                collection.DisplayElements();
            }
            if (option == 5)
            {
                Console.Write("\nInform an index: ");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine(collection.ElementAt(index));
            }
            if (option == 6)
            {
                Console.WriteLine(collection.MaxElement());
            }
            if (option == 7)
            {
                Console.WriteLine(collection.MinElement());
            }
            if (option == 8)
            {
                Console.Write("\nInform an input: ");
                double element = double.Parse(Console.ReadLine());
                Console.WriteLine(collection.NumberSpecificElements(element));
            }
            if (option == 9)
            {
                Console.WriteLine("\nInform two integers.");
                Console.WriteLine("The first represents the first element of the sequence.");
                Console.WriteLine("The second represents the last element of the sequence.\n");
                Console.Write("The first index is: ");
                int first = int.Parse(Console.ReadLine());
                Console.Write("The last index is: ");
                int last = int.Parse(Console.ReadLine());
                collection.PrintFromTo(first, last);
            }
            if (option == 10)
            {
                Console.WriteLine("\nInform an index and an element.\n");
                Console.Write("The index: ");
                int index = int.Parse(Console.ReadLine());
                Console.Write("The element: ");
                double element = double.Parse(Console.ReadLine());
                collection.ReplaceAt(index, element);
            }
            if (option == 11)
            {
                Console.WriteLine("\nInform the newest size of the array.");
                Console.WriteLine("The new size must be bigger than the current one.\n");
                Console.Write("The newest size: ");
                int newSize = int.Parse(Console.ReadLine()); ;
                collection.Resize(newSize);
            }
            if (option == 12)
            {
                Console.WriteLine("\nInform two integers.");
                Console.Write("First index: ");
                int index1 = int.Parse(Console.ReadLine());
                Console.Write("Second index: ");
                int index2 = int.Parse(Console.ReadLine());
                collection.Swap(index1, index2);
            }
            if (option == 0)
            {
                break;
            }
        }
    }

    else if (type == 3)
    {
        var collection = new GenericCollection<string>();
        while (true)
        {
            Options2();
            Message();
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.Write("\nInform an input to be added to collection: ");
                string input = Console.ReadLine();
                collection.Add(input);
            }
            if (option == 2)
            {
                collection.ArrayLength();
            }
            if (option == 3)
            {
                Console.WriteLine("\nInform two integers.\n");
                Console.Write("First integer: ");
                int index1 = int.Parse(Console.ReadLine());
                Console.Write("Second integer: ");
                int index2 = int.Parse(Console.ReadLine());
                Console.WriteLine(collection.CheckEquality(index1, index2));
            }
            if (option == 4)
            {
                collection.DisplayElements();
            }
            if (option == 5)
            {
                Console.Write("\nInform an index: ");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine(collection.ElementAt(index));
            }
            if (option == 6)
            {
                Console.WriteLine(collection.MaxElement());
            }
            if (option == 7)
            {
                Console.WriteLine(collection.MinElement());
            }
            if (option == 8)
            {
                Console.Write("\nInform an input: ");
                string element = Console.ReadLine();
                Console.WriteLine(collection.NumberSpecificElements(element));
            }
            if (option == 9)
            {
                Console.WriteLine("\nInform two integers.");
                Console.WriteLine("The first represents the first element of the sequence.");
                Console.WriteLine("The second represents the last element of the sequence.\n");
                Console.Write("The first index is: ");
                int first = int.Parse(Console.ReadLine());
                Console.Write("The last index is: ");
                int last = int.Parse(Console.ReadLine());
                collection.PrintFromTo(first, last);
            }
            if (option == 10)
            {
                Console.WriteLine("\nInform an index and an element.\n");
                Console.Write("The index: ");
                int index = int.Parse(Console.ReadLine());
                Console.Write("The element: ");
                string element = Console.ReadLine();
                collection.ReplaceAt(index, element);
            }
            if (option == 11)
            {
                Console.WriteLine("\nInform the newest size of the array.");
                Console.WriteLine("The new size must be bigger than the current one.\n");
                Console.Write("The newest size: ");
                int newSize = int.Parse(Console.ReadLine()); ;
                collection.Resize(newSize);
            }
            if (option == 12)
            {
                Console.WriteLine("\nInform two integers.");
                Console.Write("First index: ");
                int index1 = int.Parse(Console.ReadLine());
                Console.Write("Second index: ");
                int index2 = int.Parse(Console.ReadLine());
                collection.Swap(index1, index2);
            }
            if (option == 0)
            {
                break;
            }
        }
    }

    else if (type == 0)
    {
        break;
    }
}
