using System;

namespace Net50 
{
    internal class Customer
    {
        public int CustomerId { get; init; }
        public string Name { get; set; }
    }

    public class InitOnlySetter
    {

        public void TestMethod()
        {
            var instance = new Customer() { Name = "Pepe", CustomerId = 2 };
            Console.WriteLine($"instance: ({instance.CustomerId},{instance.Name})" );
            Console.ReadLine();
        }
    }
}
