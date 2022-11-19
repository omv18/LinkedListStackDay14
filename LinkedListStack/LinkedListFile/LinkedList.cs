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
        public void IndexAdd(int position, int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            if(position == 0)
            {
                newNode.next = head;
                head = newNode;
                return;
                //AddFirst(data);
                //return;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while(current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newNode.next = prev.next;
            prev.next = newNode;
        }
        public void Pop()  //DeleteFirst
        {
            if(this.head == null)
            {
                Console.WriteLine("LL is empty");
                return;
            }
            head = head.next;
            return;
        }
        public void PopLast() // Delete last
        {
            if(this.head == null)
            {
                Console.WriteLine("LL is empty.");
                return;
            }
            if(head.next == null)
            {
                head = null;
                return;
            }
            Node temp = head;
            Node previous = null;
            while(temp.next != null)
            {
                previous = temp;
                temp = temp.next;
            }
            previous.next = null; 
            return;
        }
        public int Search(int search)
        {
            if (head == null)
            {
                Console.WriteLine("LL is empty");
                return -1;
            }
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                if (temp.data.Equals(search))
                {
                    Console.WriteLine("{0} given Node is found at the index", count);
                    return count;
                }
                count++;
                temp = temp.next;
            }
            return -1;
        }
        public int MsTestSearch(int search)
        {
            AddFirst(70);
            AddFirst(30);
            AddFirst(56);
            return Search(search);
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
