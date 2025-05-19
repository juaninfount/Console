using System;

namespace netx
{

    delegate void MultiDelegate();

    public class MultiDelegates
    {
        public static void TestMultiDelegates()
        {
            MultiDelegate multiDelegate = new MultiDelegate(Task1);
            multiDelegate += Task2;
            multiDelegate += Task3;
            multiDelegate();
        }

        public static void Task1()
        {
            Console.WriteLine("Task 1");
        }

        public static void Task2()
        {
            Console.WriteLine("Task 2");
        }

        public static void Task3()
        {
            Console.WriteLine("Task 3");
        }
    }
}