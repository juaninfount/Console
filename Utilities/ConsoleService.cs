using System;

namespace Utilities
{
    public class ConsoleService
    {

        public void ChangeForegroundColor(ConsoleColor color){
            Console.ForegroundColor = color;
        }

        public void ResetConsoleValues()
        {
            Console.ResetColor();
        }
    }
}
