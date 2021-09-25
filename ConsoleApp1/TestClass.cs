using Utilities;
using Algorithms;
using Net50;
using ConsoleApp1.DataObjects;
using System;

namespace ConsoleApp1
{
    public static class TestClass
    {               

        #region "Algorithms"

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

        public static void DSA()
        {
            int[] newarray = new int[10]{34,0,56,11,22,3445,6677,12,1,-2};
            var filteredarray = Array.FindAll(newarray, x=>x != 0);
            
            Console.WriteLine(string.Format("String original: {0}", IterateArray(newarray)));
            Console.WriteLine(string.Format("String filtrado: {0}", IterateArray(filteredarray)));
        }

        private static string IterateArray(int[] items)
        {
            string string_array = "[";
            for(var i=0; i<items.Length; i++)
            {
                if(i == 0)
                    string_array += Convert.ToString(items[i]);
                else
                    string_array += " " + Convert.ToString(items[i]);
            }
            string_array += "]";

            return string_array;
        }
        
        #endregion 
 
        #region  "Net5.0"
        
        public static void TestRecord()
        {
            var obj = new Record();
            obj.TestMethod1();
            obj.TestMethod2();
        }   

        public static void TestDelegates()
        {            
            /*
            var customdelegate  = new Delegates.ResultToString<double,double>(Delegates.OperationAddition);
            var customdelegate2 = new Delegates.ResultToString<string,string>(Delegates.Concatenation);

            result = customdelegate(12,23);
            Console.WriteLine("Resultado de operacion adición (1): " + result);

            var result = customdelegate(12,23.4);
            Console.WriteLine("Resultado de operación adición (2): " + result);
            
            result = customdelegate(134545698281232,2837828732249841);
            Console.WriteLine("Resultado de operacion adición (3): " + result);

            result = customdelegate2("AC","BD");
            Console.WriteLine("Resultado de concatenación (4): " + result);
            */
            
            Console.WriteLine($"Resultado de operacion adición (1): {Delegates.Task1(12,23)}");
            Console.WriteLine($"Resultado de operación adición (2): {Delegates.Task2(12.0,23.4)}");
            Console.WriteLine($"Resultado de operación adición (3): {Delegates.Task3(134545698281232,2837828732249841)}");            
            Console.WriteLine($"Resultado de concatenación     (4): {Delegates.Task4("AC","BD")}");
        }

        #endregion     

        #region "Utilities"

        public static void TestLinqSamples()
        {
            LinqSamples l = new LinqSamples();
            
            Console.WriteLine("JOIN OPERATIONS BETWEEN TWO COLLECTIONS");
            l.TestJoin();

            Console.WriteLine("MULTIPLE ORDERING CRITERIA ");
            l.TestJoin2();
            Console.Read();          
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

        #endregion    
    }
}