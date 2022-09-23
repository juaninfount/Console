using System;

namespace Net50
{
    public class Delegates    
    {
        #region  "Sumas"

        public static string Task1(int x, int y)
        {                        
            var result = OverloadingOperations.Add(x,y);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Task 1 completed");            
            return result;
        }

        public  static string Task2(double x, double y)
        {
            var result = OverloadingOperations.Add(x,y);
            System.Threading.Thread.Sleep(1000);     
            Console.WriteLine("Task 2 completed");            
            return result;
        }

        public static string Task3(Int64 x, Int64 y)
        {
            var result = OverloadingOperations.Add(x,y);
            System.Threading.Thread.Sleep(1000);     
            Console.WriteLine("Task 3 completed");            
            return result;
        }

        #endregion

        #region  "Multiplicacion"

        public static int TaskMultiplication(int x, int y)
        {                                    
            System.Threading.Thread.Sleep(1000);            
            Console.WriteLine("Task multiplication completed");            
            return (x*y);
        }

        public static double TaskMultiplication(double x, double y)
        {                                    
            System.Threading.Thread.Sleep(1000);            
            Console.WriteLine("Task multiplication completed");            
            return (x*y);
        }

        public static long TaskMultiplication(long x, long y)
        {                                    
            System.Threading.Thread.Sleep(1000);            
            Console.WriteLine("Task multiplication completed");            
            return (x*y);
        }

        #endregion
          
        #region  "Concatenacion"

        public static string Task4(string s1, string s2)
        {
            var result = OverloadingOperations.Concat(s1, s2);
            System.Threading.Thread.Sleep(1000);     
            Console.WriteLine("Task 4 completed");
            return result;
        }

        #endregion
                    
        #region Delegates Section

        public delegate string ResultToString<T,M>(T t, M m);
        public delegate T Multiplicator<T, S>(T t, S s);
            
        #endregion     
        
    }    

    
}