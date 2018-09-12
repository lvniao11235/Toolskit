using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Extensions;
using Newtonsoft.Json;

namespace Toolskit
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj  = new Student(){ name = "lvniao", age = 12, birthday=DateTime.Now };
            string str = obj.ToJson(new DateTimeJsonConverter("yyyyMMddHHmmss"));
            Console.WriteLine(str);
            var newobj = obj.Parse<Student>(str, new DateTimeJsonConverter("yyyyMMddHHmmss"));
            Console.WriteLine(newobj.ToJson());
        }
    }

    public class Student
    {
        public string name { get; set; }

        public int age { get; set; }

        public DateTime birthday { get; set; }
    }
}
