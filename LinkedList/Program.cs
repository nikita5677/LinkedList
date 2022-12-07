using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC8
            Console.WriteLine("Hello LinkedList!");
            UC8LinkedList list = new UC8LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            list.Display();
            Console.ReadKey();
        }
    }
}