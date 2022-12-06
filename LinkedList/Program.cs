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
            //UC2
            Console.WriteLine("Hello LinkedList!");
            UC2LinkedList List = new UC2LinkedList();
            List.add(70);
            //list.Display();
            //Console.WriteLine("After Insertion Of 30");
            List.add(30);
            //list.Display();
            //Console.WriteLine("After Insertion Of 56");
            List.add(56);
            List.Display();
        }
    }
}