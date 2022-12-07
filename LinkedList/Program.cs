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
            //UC9
            UC9LinkedList list = new UC9LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            list.Display();
            Console.Write("Enter The Element You Have To Delete:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Previous Element Of That Element You Have To Delete:");
            int b = Convert.ToInt32(Console.ReadLine());
            list.Delete(b, a);
            list.Display();
            list.size();
        }
    }
}