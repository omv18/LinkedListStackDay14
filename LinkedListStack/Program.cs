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
                Console.Write("Enter the option :  1. Display 2. Add Last 3.Add First 4.Index Add : ");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        ll.Display();
                        break;
                    case 2:
                        ll.AddLast(56);
                        ll.AddLast(30);
                        ll.AddLast(70);
                        break;
                    case 3:
                        ll.AddFirst(70);
                        ll.AddFirst(30);
                        ll.AddFirst(56);
                        break;
                    case 4:
                        ll.AddLast(56);
                        ll.AddLast(70);
                        ll.IndexAdd(1, 30);
                        break;
                    default:
                        flag = false;
                        break; 
                }
            }
        }
    }
}