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

            //add item to the top of the stack
            myStack.Push("first stack");
            myStack.Push("Second stack");
            myStack.Push("Third stack");
            myStack.Push("fourth stack");

            //Pop removes the item that has just been added
            myStack.Pop();
            foreach(var item in myStack)
            {
                Console.WriteLine(item);
            }

            //Dictionary
            //declare a dictionary
            var myDic = new Dictionary<int, string>(); //add the key and item 

            //Add items into a dictionary is the same as adding in the list
            myDic.Add(1, "Bruno");
            myDic.Add(2, "Bryn");
            myDic.Add(3, "Phil");
            myDic.Add(4, "Nish");

            //alternately 
            //var personDic = new Dictionary<int, string>()
            //{
            //    {1, "Bruno" },
            //    {2, "Nish" }
            //};

            myDic.TryAdd(1, "Bruno"); //this wont add because bruno already exists
            foreach(var item in myDic)
            {
                Console.WriteLine($"Index is: {item.Key} and the name is {item.Value}");
            }
        }
    }
}
