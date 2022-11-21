using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListStack.LinkedListFile;

namespace LinkedListStack.ExtraCode
{
    internal class Stack : LinkedList
    {
        public void Push(int data)
        {
            AddLast(data);
        }

        public void DisplayStack()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Display();
            }
        }
        public void PopUntilStackIsEmpty()
        {
            do
            {
                int count = PopLast();
                Console.WriteLine("{0} is pop in stack", count);
            }
            while (head != null);
        }
    }
}
