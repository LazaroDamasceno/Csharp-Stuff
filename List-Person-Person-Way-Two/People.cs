using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class People : Person
    {
        public List<Person> person = new();

        public void AddData(string Name, int Age, int Id)
        {
            person.Add(new Person { name = Name, age = Age, id = Id });
        }

        public void ChangeElement(int index)
        {
            while (true)
            {
                Console.WriteLine("--Operation to update data--");
                Console.WriteLine("Select an option:");
                Console.WriteLine("1 - update the name.");
                Console.WriteLine("2 - update the age.");
                Console.WriteLine("3 - update de the id.");
                Console.WriteLine("4 - cancel.");
                Console.WriteLine();
                int input = int.Parse(Console.ReadLine());
                if (input == 4)
                {
                    Console.WriteLine("--Operation of changing data cancelled--");
                    Console.WriteLine();
                    break;
                }
                else if (input == 1)
                {
                    Console.Write("Change the name: ");
                    person[index].name = Console.ReadLine();
                    Console.WriteLine();
                }
                else if (input == 2)
                {
                    Console.Write("Change the age: ");
                    person[index].age = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                else if (input == 3)
                {
                    Console.Write("Change the id: ");
                    person[index].id = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                Console.WriteLine("--Change done--");
                Console.WriteLine();
            }
        }

        public int SizeList()
        {
            return person.Count;
        }

        public void RemoveDataAt(int index)
        {
            person.RemoveAt(index);
        }

        public void ClearList()
        {
            person.Clear();
            Console.WriteLine();
        }

        public void DisplayDataAt(int index)
        {
            Console.WriteLine($"Name ---> {person[index].name}");
            Console.WriteLine($"Age ---> {person[index].age}");
            Console.WriteLine($"Id ---> {person[index].id}");
            Console.WriteLine();
        }

        public void DisplayData()
        {
            int counter = 0;
            foreach (Person p in person)
            {
                Console.WriteLine($"Element #{++counter}");
                Console.WriteLine($"Name ---> {p.name}");
                Console.WriteLine($"Age ---> {p.age}");
                Console.WriteLine($"Id ---> {p.id}");
                Console.WriteLine();
            }
        }
    }
}
