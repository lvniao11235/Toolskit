using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Extensions;

namespace Toolskit
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj  = new { name = "lvniao", age = 12 };
            Console.WriteLine(obj.ToJson());
        }
    }
}
