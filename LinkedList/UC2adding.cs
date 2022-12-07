using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class UC2LinkedList
    {
        Node head = null;
        public void add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
                Console.WriteLine(node.data + ":Inserted SuccessFully");
            }
            else
            {
                Node addr = new Node(data);
                Node h1 = null;
                h1 = this.head;
                this.head = addr;
                Node temp = addr;
                temp.next = h1;
                Console.WriteLine(addr.data + ":Inserted SuccessFully");
            }
        }
        
        public void Display()
        {
            if (this.head == null)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Values In LinkedList Are:");
                while (this.head != null)
                {
                    Console.Write(this.head.data + " ");
                    this.head = this.head.next;
                }
            }
        }
    }
}
