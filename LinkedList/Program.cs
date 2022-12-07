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
            //UC4
            Console.WriteLine("Hello LinkedList!");
            UC4LinkedList list = new UC4LinkedList();
            list.Add(56);
            //list.Add(30);
            list.Add(70);
            list.InsertAtParticularPosition(2, 30);
            list.Display();
            Console.ReadKey();
        }
    }
}