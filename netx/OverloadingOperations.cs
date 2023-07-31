using System;

namespace netx
{
    public static class OverloadingOperations
    {        
        public static string Add(double x, double y)
        {
            return (x + y).ToString();
        }

        public static string Add(int x, int y)
        {
            return (x + y).ToString();
        }

        public static string Add(long x, long y)
        {
            return (x + y).ToString();
        }

        public static string Concat(string str1, string str2)
        {
            return (str1 + str2);
        }
    }
}