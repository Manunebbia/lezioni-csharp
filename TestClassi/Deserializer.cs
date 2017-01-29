using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestClassi
{
    static class Deserializer
    {
        public static void deserialize()
        {
            string[] data = File.ReadAllLines(@"..\..\monsters.csv");
            Console.WriteLine(data[1]);
        }
    }
}
