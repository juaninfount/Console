using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class KeyPair
    {
       
        public static void TestCase1()
        {            
            //int T = 1;
            int[] A = new int[10] { 13, 21, 6,  5, 14, 11, 2, 3 , 10, 9  };
            string ArrayList = string.Join(",", A);
            // N = A.Length;
            int sum = 23;

            Console.WriteLine("Algoritmo KeyPair");
            Console.WriteLine("Número de casos: {0}", 1);
            Console.WriteLine("Array: {0}", ArrayList);

            string result = Solve(A, sum);
            Console.WriteLine();
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void TestCase2()
        {            
            int[] A = new int[10] { 25, 21, 6, 5, 14, 11, -2, 3, 10, 9 };
            string ArrayList = string.Join(",", A);            
            int sum = 23;

            Console.WriteLine("Algoritmo KeyPair");
            Console.WriteLine("Número de casos: {0}", 1);
            Console.WriteLine("Array: {0}", ArrayList);

            string results = Solve2(A, sum);
            Console.WriteLine();
            Console.WriteLine(results);
            Console.ReadLine();
        }

        /// <summary>
        ///  Si existen al menos dos numeros en array A, que sumen x
        /// </summary>
        /// <param name="A"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static string Solve(int[] A, int x)
        {
            int N = A.Length;
            List<int> tempLst = A.ToList();
            tempLst.Sort();
            A = tempLst.ToArray();
            
            //for (int i=0; i<= (N - 1); i++)
            int i = 0; int j = N - 1;
            for(;;)
            {
                var sumTemp = A[i] + A[j];
                if (sumTemp > x)
                {
                    j--;
                }
                else if (sumTemp < x)
                {
                    i++;
                }
                else if (sumTemp == x) {                    
                    return string.Format("{0} + {1} = {2}", A[i], A[j], x);
                }
                                
                if (i >= N){
                    break;
                }
            }
            return "No results";
        }

        /// <summary>
        /// Mostrar todas las combinaciones de dos numeros en un array A, que sumen x
        /// </summary>
        /// <param name="A"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static string Solve2(int[] A, int x)
        {
            int N = A.Length;
            string results = "";

            Dictionary<int, List<int>> keyValues = new Dictionary<int, List<int>>();
            List<int> tempLst = A.ToList();
            tempLst.Sort();
            A = tempLst.ToArray();
            
            int i = 0; int j = N - 1;
            while (i < j)
            {
                var sumTemp = A[i] + A[j];
                if (sumTemp > x)
                {
                    j--;
                }
                else if (sumTemp < x)
                {
                    i++;
                }
                else if (sumTemp == x)
                {
                    if (!keyValues.Any( z=>z.Value.Contains(A[i]) && z.Value.Contains(A[j]))) {
                        var cnt = keyValues.Count;
                        keyValues.Add(cnt, new List<int> { A[i], A[j] });
                        results += string.Format("{0} + {1} = {2}", A[i], A[j], x) + "\n";
                    }

                    i++;
                }               
            }

            results = string.IsNullOrEmpty(results) ? "No results" : results;
            return results;
        }
    }
}
