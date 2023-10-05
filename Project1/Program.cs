using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        int i; bool flag;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Program p = new  Project1.Program();
            Console.WriteLine($"value of is : {p.i}");
            Console.WriteLine($"value of p is :{p.flag}");
            Console.ReadLine();
        }
    }
}
