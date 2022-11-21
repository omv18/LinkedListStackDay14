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
        public int count = 0;
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            if(this.head == null)
            {
                count++;
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
                count++;
            }
        }
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if(this.head == null)
            {
                count++;
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
                count++;
                temp.next = newNode;
            }
        }
        public void IndexAdd(int position, int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                count++;
                head = newNode;
                return;
            }
            if(position == 0)
            {
                count++;
                newNode.next = head;
                head = newNode;
                return;
                //AddFirst(data);
                //return;
            }
            Node prev = null;
            Node current = this.head;
            int currentPostion = 0;
            while(current != null && currentPostion < position)
            {
                prev = current;
                current = current.next;
                currentPostion++;
            }
            count++;
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
            count--;
            head = head.next;
            return;
        }
        public int PopLast() // Delete last
        {
            if(this.head == null)
            {
                Console.WriteLine("LL is empty.");
                return -1;
            }
            if(head.next == null)
            {
                count--;
                int storeHead = head.data;
                head = null;
                return storeHead;
            }
            Node temp = head;
            Node previous = null;
            while(temp.next != null)
            {
                previous = temp;
                temp = temp.next;
            }
            previous.next = null;
            count--;
            return temp.data;
        }
        public int Search(int searchValue)
        {
            if (head == null)
            {
                Console.WriteLine("LL is empty");
                return -1;
            }
            Node temp = head;
            int searchCount = 0;
            while (temp != null)
            {
                if (temp.data.Equals(searchValue))
                {
                    Console.WriteLine("{0} given Node is found at the index", searchCount);
                    return searchCount;
                }
                searchCount++;
                temp = temp.next;
            }
            return -1;
        }

        public int SearchAfterAdd(int find, int data)
        {
            Node newnode = new Node(data);
            if(head == null)
            {
                Console.WriteLine("LL is empty");
                return -1;
            }
            Node temp = head;
            int index = 0;
            while(temp != null)
            {
                index++;
                if(temp.data == find)
                {
                    newnode.next = temp.next;
                    temp.next = newnode;
                    count++;
                    return index;
                }
                temp = temp.next;
            }
            return -1;
        }
        public void SearchAndDelete(int value)
        {
            if(head == null)
            {
                Console.WriteLine("LL is empty.So we are unable to delete.");
                return;
            }
            if(count == 1)
            {
                head = null;
                count--;
                return;
            }
            Node prev = head;
            Node temp = head.next;
            while(temp != null)
            {
                if(temp.data == value)
                {
                    Console.WriteLine("inside loop");
                    prev.next = temp.next;
                    temp = null;
                    count--;
                    return;
                }
                prev = temp;
                temp = temp.next;
            }
        }

        public int MsTestSearch(int searchValue)
        {
            AddFirst(70);
            AddFirst(30);
            AddFirst(56);
            return Search(searchValue);
        }
        public bool MsTestSearchAdd(int find , int add)
        {
            AddLast(56);
            AddLast(30);
            AddLast(70);
            int findIndex = Search(find);
            int addIndex = SearchAfterAdd(find, add);
            if (findIndex.Equals(addIndex - 1)) return true;
            return false;
            
        }
        public int MsTestSearchDelete(int value)
        {
            AddLast(56);
            AddLast(30);
            AddLast(70);
            SearchAndDelete(value);
            return Search(value);
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
