using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStack.LinkedListFile
{
    public class LinkedList
    {
        public Node head;

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            if(this.head == null)
            {
                head = newNode;
                return;
            }
            else
            {
                //newNode.next = head;
                //head = newNode;
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if(this.head == null)
            {
                this.head = newNode;
                //return;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }

        public void Display()
        {
            if(head == null)
            {
                Console.WriteLine("LL is empty");
                return;
            }
            while(head != null)
            {
                Console.Write(head.data + " -> ");
                head = head.next;
            }
            Console.WriteLine("Null");
        }
    }
}
