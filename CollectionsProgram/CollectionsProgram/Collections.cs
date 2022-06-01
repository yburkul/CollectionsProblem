using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProgram
{
    public class Collections
    {   
        public static void AddStack()
        {
            Stack<int> stack = new Stack<int>();    
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            Console.WriteLine("The Element in Stack are: ");
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nWelcome in Stack Opertions");
            int input;
            do
            {
                Console.WriteLine("\n1: Display the Top Element");
                Console.WriteLine("2: Checking the element is Present in the Stack or not");
                Console.WriteLine("3: Remove Element from stack");
                Console.WriteLine("4: Clear All Stack");
                Console.WriteLine("0: Please Go back in Main Method");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Top Element: " + stack.Peek());
                        break;
                    case 2:
                        Console.WriteLine("Check Element Present or not: " + stack.Contains(30));
                        break;
                    case 3:
                        Console.WriteLine("Remove the Element: " + stack.Pop());
                        Console.WriteLine("After Remove the Top Element is: " + stack.Peek());
                        break;
                    case 4:
                        Console.WriteLine("Count the stack element: " + stack.Count);
                        stack.Clear();
                        Console.WriteLine("count the stack element after clear the stack: " + stack.Count);
                        break;
                    case 0:
                        Console.WriteLine("Ok");
                        break;
                    default:
                        Console.WriteLine("Invalid Input:----Please Enter a Correct Input");
                        break;
                }
            }
            while (input != 0);
        }

        public static void AddQueue()
        {
            Queue<string> queue = new Queue<string>();  
            queue.Enqueue("Yogesh");
            queue.Enqueue("Ganesh");
            queue.Enqueue("Rohit");
            queue.Enqueue("Arjun");
            Console.WriteLine("The Element in Queue are: ");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
;
            Console.WriteLine("\nWelcome in Queue Opertions");
            int input;
            do
            {                
                Console.WriteLine("\n1: Displaying the beginning Element of Queue");
                Console.WriteLine("2: Checking the Element is Present or Not");
                Console.WriteLine("3: Remove Element from Queue");
                Console.WriteLine("4: Clear All the Element");
                Console.WriteLine("0: Please Go back in Main Method");
                input = int.Parse(Console.ReadLine());
                switch(input)
                {
                    case 1:
                        Console.WriteLine("The beginning element is: " + queue.Peek());
                        break;
                    case 2:
                        Console.WriteLine("Check The Element is Present Or Not: " + queue.Contains("Arjun"));
                        Console.WriteLine("Check The Element is Present Or Not: " + queue.Contains("Sachin"));
                        break;
                    case 3:
                        Console.WriteLine("Before Removing Element Count is: " + queue.Count);
                        Console.WriteLine("Removing the Element From Queue is: " + queue.Dequeue());
                        Console.WriteLine("After remove queue the top element is: " + queue.Peek());
                        Console.WriteLine("After Removing Element Count is: " + queue.Count);
                        break;
                    case 4:
                        Console.WriteLine("Before Clear All Element from queue the Count is: " + queue.Count);
                        queue.Clear();
                        Console.WriteLine("After Clear All Element from queue the Count is: " + queue.Count);
                        break;
                    case 0:
                        Console.WriteLine("Ok");
                        break;
                    default:
                        Console.WriteLine("Invalid Input:----Please Enter a Correct Input");
                        break;
                }
            }
            while(input != 0);
        }
    }
}