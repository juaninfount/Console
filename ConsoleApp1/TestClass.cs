using Utilities;
using Algorithms;
using Net50;
using ConsoleApp1.DataObjects;
using System;

namespace ConsoleApp1
{
    public static class TestClass
    {               
        public static void TestQueue()
        {
            Queue<int> queue = new Queue<int>(5);
            Console.WriteLine("Testing queue - colas");
            queue.Enqueue(10);
            queue.Enqueue(13);
            queue.Enqueue(5);
            queue.Dequeue();
            //queue.Enqueue(4);
            //queue.Enqueue(7);
            queue.Dequeue();
            queue.Dequeue();
            //Console.WriteLine($"Get Front: {queue.Front()}");
            queue.Print();
            Console.ReadLine();
        }

        public static void TestStack()
        {
            Stack<string> stack = new Stack<string>(5);
            Console.WriteLine("Testing stack - pilas");
            stack.Push("uno");
            stack.Push("dos");
            stack.Push("tres");
            stack.Print();
            Console.ReadLine();   
        }

        public static void TestConsoleService()        
        {
              Util utilities = new Util();

            // SRP
            //var util = new Utilities.ConsoleService();
            //util.ResetConsoleValues();            
            //Console.WriteLine("This is the default configuration for Console");
            //util.ChangeForegroundColor(ConsoleColor.Cyan);            
            //Console.WriteLine("Color changed!");
            //Console.Read();
            
             // SRP            
            //var cadJSON =  ReadFile(@"D:\Source\dotnetcore\dotnetcore_DI\ConsoleApp1\Data\BookStore.json");
            //var bookList = JsonConvert.DeserializeObject<BookStore.BookStore>(cadJSON);
            
            Console.WriteLine(" List of Books by PACKT");
            Console.WriteLine(" ----------------------");
            string filePath = System.IO.Path.Combine(
                            System.Environment.CurrentDirectory, @"Data\BookStore2.json");
                      
            var bookList = Util.ReadData<Book>(filePath,"");
            foreach (Book item in bookList)
            {
                Console.WriteLine($" {item.Title.PadRight(39, ' ')} " +
                $"{item.Author.PadRight(15, ' ')} {item.Price}");
            }
            Console.Read();
        }
    }
}