using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniatializerObject
{
    internal class Person
    {
        public string name;
        public int age;
        public int id;
        public StringBuilder GetData()
        {
            StringBuilder data = new();
            data.Append("Person's data:");
            data.AppendLine();
            data.Append($"Name: {name}");
            data.AppendLine();
            data.Append($"Age: {age}");
            data.AppendLine();
            data.Append($"Id: {id}");
            data.AppendLine();
            return data;
        }
    }
}
