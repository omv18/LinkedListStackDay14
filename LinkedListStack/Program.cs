using LinkedListStack.LinkedListFile;
using System;
namespace LinkedListStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList ll = new LinkedList();
            bool flag = true;
            while (flag)
            {
                Console.Write("Enter the option :  1. Display 2. Add first");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        ll.Display();
                        break;
                    case 2:
                        ll.AddLast(1);
                        ll.AddLast(2);
                        ll.AddLast(3);
                        break;
                }
            }
        }
    }
}