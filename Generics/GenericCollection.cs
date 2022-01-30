using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericCollection<T>
    {
        private T[] array = new T[1];
        int mainIndex = 0;
        /*
        public void InsertAnyWhere(int index, T element) 
        {
            try
            {

            }
            catch (Exception)
            {
                Console.WriteLine("InsertAnyWhere warning: An error has happened. Inform a valid index.");
            }
        }
        */
        public void InsertAtTheBegin(T element) 
        {
            T[] newArray = new T[array.Length+1];
            newArray[0] = element;
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i+1] = array[i];
            }
            array = newArray;
            mainIndex = array.Length;
        }

        public void InsertAtTheEnd(T element)
        {
            if (mainIndex < array.Length)
            {
                array[mainIndex++] = element;
            }
            else
            {
                T[] newArray = new T[array.Length+1];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                newArray[mainIndex++] = element;
                array = newArray;    
            }
        }

        public void ReplaceAt(int index, T element)
        {
            try
            {
                array[index] = element;
            }
            catch (Exception)
            {
                Console.WriteLine("ReportAt: An error has happened. Inform a valid index.");
            }
        }
        
        public void RemoveSpecificElement(T element)
        {
            int newIndex = 0;
            T[] newArray = new T[array.Count(i => i.Equals(element) == false)];
            for (int i = 0; i < array.Length; i++)
            { 
                if (array[i].Equals(element) == false)
                {
                    newArray[newIndex++] = array[i];
                }
            }
            array = newArray;
            mainIndex = array.Length;
        }

        public void RemoveAt(int index) 
        {
            try
            {
                T[] newArray = new T[array.Length - 1];
                int newIndex = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i != index)
                    {
                        newArray[newIndex++] = array[i];
                    }
                }
                array = newArray;
                mainIndex = array.Length;
            }
            catch (Exception)
            {
                Console.WriteLine("RemoveAt warning: An error has happened. Inform a valid index.");
            }
        }

        public void RemoveFirst()
        {
            T[] newArray = new T[array.Length-1];
            for (int i = 1;i < array.Length;i++)
            {
                newArray[i-1] = array[i];
            }
            array = newArray;
            mainIndex = array.Length; 
        }

        public void RemoveLast()
        {
            T[] newArray = new T[array.Length - 1];
            for (int i = 0; i < array.Length-1; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
            mainIndex = array.Length;
        }

        public void Resize(int newSize)
        {
            try
            {
                T[] newArray = new T[newSize];
                mainIndex = array.Length;
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }
            catch (Exception)
            {
                Console.WriteLine("Resize: An error has happened. Inform a valid new size.");
            }

        }

        public void Length() => Console.WriteLine(array.Length);

        public void Sort() => Array.Sort(array);

        public void Reverse() => Array.Reverse(array);

        public void MaxElement() => Console.WriteLine(array.Max());

        public void MinElement() => Console.WriteLine(array.Min());
        
        public void Clear()
        {
            array = new T[1];
            mainIndex = 0;
        }

        public void DisplayFromTo(int begin, int end)
        {
            if (begin < 0 
                && begin >= array.Length 
                && begin >= end 
                && end <= begin 
                && end >= array.Length)
            {
                for (int i = begin; i <= end; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("DisplayFromTo warning: An error has happened. Inform, two correct indexes.");
            }

        }

        public void DisplayElementAt(int index)
        {
            try
            {
                Console.WriteLine(array[index]);
            }
            catch (Exception)
            {
                Console.WriteLine("DisplayElementAt warning: An error has happened. Inform a valid index.");
            }
        }

        public void DisplayAllElements()
        {
            foreach (T element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public void DisplayCurrentIndex()
        {
            Console.WriteLine(mainIndex);
        }
    }
}
