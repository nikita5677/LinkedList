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
            //UC7
            Console.WriteLine("Hello LinkedList");
            UC7LinkedList list = new UC7LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Search(30);
            list.Display();
            Console.ReadKey();
        }
    }
}