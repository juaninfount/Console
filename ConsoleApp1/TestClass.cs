using Utilities;
using Algorithms;
// using Net50;
// using Net60;
using System.Collections;
using ConsoleApp1.DataObjects;
using Crypto;
using System;
using netx;
using System.Linq;

namespace ConsoleApp1
{
    internal static class TestClass
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
            // llamadas o delegados
            var customdelegate = new Delegates.ResultToString<double, double>(Delegates.Task2);
            var customdelegate2 = new Delegates.ResultToString<string, string>(Delegates.Task4);
            ///  uso de sobrecarga de funciones: TaskMultiplication
            var customdelegate3 = new Delegates.Multiplicator<long, long>(Delegates.TaskMultiplication);
            var customdelegate4 = new Delegates.Multiplicator<int, int>(Delegates.TaskMultiplication);
            var customdelegate5 = new Delegates.Multiplicator<double, double>(Delegates.TaskMultiplication);

            var result = customdelegate(12, 23);
            Console.WriteLine("Resultado de operacion adición int (1): " + result);

            result = customdelegate(12.0, 23.4);
            Console.WriteLine("Resultado de operación adición double (1): " + result);

            result = customdelegate(134545698281232, 2837828732249841);
            Console.WriteLine("Resultado de operacion adición long (1): " + result);

            result = customdelegate2("AC", "BD");
            Console.WriteLine("Resultado de concatenación (4): " + result);

            Console.WriteLine($"Resultado de operacion adición (1): {Delegates.Task1(12, 23)}");
            Console.WriteLine($"Resultado de operación adición (2): {Delegates.Task2(12.0, 23.4)}");
            Console.WriteLine($"Resultado de operación adición (3): {Delegates.Task3(134545698281232, 2837828732249841)}");
            Console.WriteLine($"Resultado de concatenación     (4): {Delegates.Task4("AC", "BD")}");

            // llamada a sobrecarga de metodos 
            Console.WriteLine($"Resultado de multiplicación(long) (5): {customdelegate3(13124242, 43346546)}.");
            Console.WriteLine($"Resultado de multiplicación(int) (5): {customdelegate4(132, 465)}.");
            Console.WriteLine($"Resultado de multiplicación(double) (5): {customdelegate5(132.42, 4654.26)}.");

            // Delegate that takes an int array and returns the sum
            // ...inside TestDelegates...
            Delegates.ArraySumDelegate sumArrayDelegate = (arr) => arr.Sum();

            var arrayvariable = new int[6] { 223, 34, 46, -5, 10, 73 };
            Console.WriteLine($"Suma de los elementos del array: {sumArrayDelegate(arrayvariable)}");

            MultiDelegates.TestMultiDelegates();
            
        }

        #endregion

        #region "Utilities"

        public static void TestLinqSamples()
        {
            LinqSamples l = new LinqSamples();
            /*
            Console.WriteLine("JOIN OPERATIONS BETWEEN TWO COLLECTIONS");
            l.joinOperations();

            Console.WriteLine("MULTIPLE ORDERING CRITERIA ");
            l.multipleOrderingCriteria();
            */

            Console.WriteLine("GROUPING BY COLUMNS");
            l.groupByCriteria();
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

        #region "Crypto"

        public static void Rfc2898Test(string[] args)
        {
           Crypto.RFC2898.Main(args);
           Console.Read();
        }

        #endregion

        #region  "Net6.0"

        public static void TestRecord2()
        {
            var obj = new RecordTypes();
            obj.testRecordTypes();
        }

        public static void TestMatchPattern()
        {
            netx.MatchPattern.matchInSwitch();
        }

        public static void TestSwitchExpression(){
            netx.MatchPattern.switchExpression();
        }

        public static void TestPatternMatchingCollections(){
            netx.MatchPattern.patternMatchingCollections();
        }

        public static void TestCatchingWithFilter(){
            var obj = new netx.HandlingException();
            obj.catchingWithFilter();
        }

        #endregion

    }
}