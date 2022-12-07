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
            //UC6
            Console.WriteLine("Hello LinkedList");
            UC6LinkedList list = new UC6LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            Console.WriteLine("After Removal of Last node then linked list is");
            list.RemovaLastNode();
            list.Display();
            Console.ReadKey();
        }
    }
}