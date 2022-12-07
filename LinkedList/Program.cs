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
            //UC5
            Console.WriteLine("Hello LinkedList");
            UC5LinkedList list = new UC5LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            Console.WriteLine("After Removal of first node then linked list is");
            list.RemoveFirstNode();
            list.Display();
            Console.ReadKey();
        }
    }
}