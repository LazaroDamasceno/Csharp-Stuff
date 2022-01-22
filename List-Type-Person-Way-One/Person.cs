using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    internal class Person
    {
        public string name;
        public uint age;
        public uint id;
        public string adress;
        public string socialStatus;
        public bool isWorking;
        public bool hasUniDegree;       
        public StringBuilder PersonInfo()
        {
            StringBuilder personInfo = new();
            personInfo.Append("---------------------");
            personInfo.AppendLine();
            personInfo.Append("---------------------");
            personInfo.AppendLine();
            personInfo.Append($"Name: {name}");
            personInfo.AppendLine();
            personInfo.Append($"Age: {age}");
            personInfo.AppendLine();
            personInfo.Append($"Id: {id}");
            personInfo.AppendLine();
            personInfo.Append($"Adress: {adress}");
            personInfo.AppendLine();
            personInfo.Append($"Social status: {socialStatus}");
            personInfo.AppendLine();
            personInfo.Append($"Is working: {isWorking}");
            personInfo.AppendLine();
            personInfo.Append($"Has university degree: {hasUniDegree}");
            personInfo.AppendLine();
            personInfo.Append("---------------------");
            personInfo.AppendLine();
            personInfo.Append("---------------------");
            personInfo.AppendLine();
            return personInfo;
        }
    }
}