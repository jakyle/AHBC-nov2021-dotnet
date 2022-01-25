using System;
using System.Collections.Generic;

namespace stacksandqueues
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Queue, FIFO -> First in First out
            var nameQueue = new Queue<string>();


            // entering your "line" or queue
            nameQueue.Enqueue("James");
            nameQueue.Enqueue("Kyle");
            nameQueue.Enqueue("Corn");
            nameQueue.Enqueue("Bob");
            nameQueue.Enqueue("Carson");
            nameQueue.Enqueue("Leon");


            Console.WriteLine(nameQueue.Peek());

            var name = nameQueue.Dequeue();

            Console.WriteLine(name);

           // Stack, LIFO
           var nameStack = new Stack<string>();


            // adding to the stack
            nameStack.Push("James");
            nameStack.Push("Kyle");
            nameStack.Push("Corn");
            nameStack.Push("Bob");
            nameStack.Push("Carson");
            nameStack.Push("Leon");

            // remove or "pop" from the stack
            nameStack.Pop();
            nameStack.Pop();
            var currentName = nameStack.Pop();

            Console.WriteLine(currentName);

            Console.ReadLine();
        }
    }
}
