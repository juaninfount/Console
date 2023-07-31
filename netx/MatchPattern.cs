using System.Security.Cryptography;

/*
C# 11 and .NET 7 – Modern Cross-Platform Development Fundamentals
Chapter 3
*/

namespace netx
{
    public enum Direction
    {
        Up,
        Down,
        Right,
        Left
    }

    public enum Orientation
    {
        North,
        South,
        East,
        West
    }

    public static class MatchPattern
    {
        public static void matchInSwitch()
        {
            int number = RandomNumberGenerator.GetInt32(1, 8);
            Console.WriteLine("My random number is " + number + ".");

            switch (number)
            {
                case 1:
                    Console.WriteLine("One");
                    break; // jumps to end of switch statement
                case 2:
                    Console.WriteLine("Two");
                    goto case 1;
                case 3: // multiple case section
                case 4:
                    Console.WriteLine("Three or four");
                    goto case 1;
                case 5:
                    goto A_label;
                default:
                    Console.WriteLine("Default");
                    break;
            } // end of switch statement
            Console.WriteLine("After end of switch");
        A_label:
            Console.WriteLine($"After A_label");
        }

        internal static Orientation ToOrientation(Direction direction)
                => direction switch
                {
                    Direction.Up => Orientation.North,
                    Direction.Right => Orientation.East,
                    Direction.Down => Orientation.South,
                    Direction.Left => Orientation.West,
                    _ => throw new
                     ArgumentOutOfRangeException(nameof(direction),
                                         $"Not expected direction value: {direction}"),
                };

        public static void switchExpression()
        {
            var direction = Direction.Right;
            Console.WriteLine($"Direction 1 is {direction} view.");
            Console.WriteLine($"Cardinal orientation is {ToOrientation(direction)}.");

            direction = Direction.Up;
            Console.WriteLine($"Direction 2 is {direction} view.");
            Console.WriteLine($"Cardinal orientation is {ToOrientation(direction)}.");
        }

        public static void patternMatchingCollections()
        {
            int[] sequentialNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] oneTwoNumbers = new int[] { 1, 2 };
            int[] oneTwoTenNumbers = new int[] { 1, 2, 10 };
            int[] oneTwoThreeTenNumbers = new int[] { 1, 2, 3, 10 };
            int[] primeNumbers = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            int[] fibonacciNumbers = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
            int[] emptyNumbers = new int[] { };
            int[] threeNumbers = new int[] { 9, 7, 5 };
            int[] sixNumbers = new int[] { 9, 7, 5, 4, 2, 10 };

            Console.WriteLine($"{nameof(sequentialNumbers)}: {CheckSwitch(sequentialNumbers)}");
            Console.WriteLine($"{nameof(oneTwoNumbers)}: {CheckSwitch(oneTwoNumbers)}");
            Console.WriteLine($"{nameof(oneTwoTenNumbers)}: {CheckSwitch(oneTwoTenNumbers)}");
            Console.WriteLine($"{nameof(oneTwoThreeTenNumbers)}: {CheckSwitch(oneTwoThreeTenNumbers)}");
            Console.WriteLine($"{nameof(primeNumbers)}: {CheckSwitch(primeNumbers)}");
            Console.WriteLine($"{nameof(fibonacciNumbers)}: {CheckSwitch(fibonacciNumbers)}");
            Console.WriteLine($"{nameof(emptyNumbers)}: {CheckSwitch(emptyNumbers)}");
            Console.WriteLine($"{nameof(threeNumbers)}: {CheckSwitch(threeNumbers)}");
            Console.WriteLine($"{nameof(sixNumbers)}: {CheckSwitch(sixNumbers)}");

        }

        static string CheckSwitch(int[] values) => values switch
        {
            [] => "Empty array",
            [1, 2, _, 10] => "Contains 1, 2, any single number, 10.",
            [1, 2, .., 10] => "Contains 1, 2, any range including empty, 10.",
            [1, 2] => "Contains 1 then 2.",
            [int item1, int item2, int item3] => $"Contains {item1} then {item2} then {item3}.",
            [0, _] => "Starts with 0, then one other number.",
            [0, ..] => "Starts with 0, then any range of numbers.",
            [2, .. int[] others] => $"Starts with 2, then {others.Length} more numbers.",
            [..] => "Any items in any order.",
        };

    }


}



