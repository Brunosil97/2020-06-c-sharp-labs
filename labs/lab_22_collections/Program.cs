using System;
using System.Collections.Generic;

namespace lab_22_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a queue
            var myQueue = new Queue<string>();
            //add to the queue
            myQueue.Enqueue("First item");
            myQueue.Enqueue("Second item");
            myQueue.Enqueue("Third item");
            myQueue.Enqueue("Fourth item");

            //look at the first item on the queue without removing
            Console.WriteLine(myQueue.Peek());
            //remove first item of a Queue
            myQueue.Dequeue();
            Console.WriteLine(myQueue.Peek());

            //See if a queue contains a particular item
            Console.WriteLine(myQueue.Contains("Third item")); //true or false

            //declare a stack
            var myStack = new Stack<string>();
        }
    }
}
