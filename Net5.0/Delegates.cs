using System;

namespace Net50
{
    public class Delegates    
    {
        public static string OperationAddition(double x, double y)
        {
            return (x + y).ToString();
        }

        public static string OperationAddition(int x, int y)
        {
            return (x + y).ToString();
        }

        public static string OperationAddition(Int64 x, Int64 y)
        {
            return (x + y).ToString();
        }

        public static string Concatenation(string str1, string str2)
        {
            return (str1 + str2);
        }

        public static string Task1(int x, int y)
        {
            var result = OperationAddition(x,y);
            System.Threading.Thread.Sleep(1000);            
            Console.WriteLine("Task 1 completed");            
            return result;
        }

        public static string Task2(double x, double y)
        {
            var result = OperationAddition(x,y);
            System.Threading.Thread.Sleep(1000);     
            Console.WriteLine("Task 2 completed");            
            return result;
        }

        public static string Task3(Int64 x, Int64 y)
        {
            var result = OperationAddition(x,y);
            System.Threading.Thread.Sleep(1000);     
            Console.WriteLine("Task 3 completed");            
            return result;
        }

        
        public static string Task4(string s1, string s2)
        {
            var result = Concatenation(s1, s2);
            System.Threading.Thread.Sleep(1000);     
            Console.WriteLine("Task 4 completed");
            return result;
        }

        #region Delegates Section

        public delegate string ResultToString<T,M>(T t, M m);
            
        #endregion     
        
    }    

    
}