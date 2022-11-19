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
                Console.Write("Enter the option :  1. Display 2. Add Last 3.Add First  : ");
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
                    case 3:
                        ll.AddFirst(70);
                        ll.AddFirst(30);
                        ll.AddFirst(56);
                        break;
                    default:
                        flag = false;
                        break; 
                }
            }
        }
    }
}