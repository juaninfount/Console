using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net50
{
    public class Record
    {
        /// <summary>
        /// Imprime objeto sin necesidad de serializar
        /// </summary>
        public void TestMethod1() 
        {
            Clase clase = new() { Name = "Héctor" };
            Person record = new("Héctor");

            Console.WriteLine(clase);
            Console.WriteLine(record);
            Console.ReadLine();
        }

        public void TestMethod2() 
        {
            Clase clase  = new() { Name = "Héctor" };
            Clase clase2 = new() { Name = "Héctor" };
            Person registro  = new("Héctor");
            Person registro2 = new("Héctor");

            // comparacion de referencias de objeto
            Console.WriteLine(clase.Equals(clase2));

            // comparacion de valores de los objetos 
            Console.WriteLine(registro.Equals(registro2));
            Console.ReadLine();
        }
    }

    internal class Clase 
    {
        public string Name { get; set; }
    }

    internal record Person(string Name);    
}
