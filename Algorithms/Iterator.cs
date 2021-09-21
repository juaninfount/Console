using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class Iterator
    {
        public void TestCase1()
        {
            /*
            StringBuilder log = new StringBuilder();
            GetEnumerable(log);
            Console.WriteLine(log.ToString())
            Console.ReadLine();
            */

            var log = new StringBuilder();
            log.AppendLine("before enumeration");
            foreach (var number in GetCustomEnumerable(log))
            {
                log.AppendLine($"{number}");
            }
            log.AppendLine("after enumeration");
            Console.WriteLine(log.ToString());
            Console.ReadLine();
        }

        public void GetEnumerable(StringBuilder log)
        {
            using (var context = new Context(log)) 
            {
                foreach (var i in Enumerable.Range(1,5)) 
                {
                    log.AppendLine($"{i}");
                    //yield return  i;
                }
            }
        }

        private IEnumerable<int> GetCustomEnumerable(StringBuilder log)
        {
            log.AppendLine("before 1");
            yield return 1;
            log.AppendLine("before 2");
            yield return 2;
            log.AppendLine("before 3");
            yield return 3;
            log.AppendLine("before 4");
            yield return 4;
            log.AppendLine("before 5");
            yield return 5;
            log.AppendLine("before end");
        }

        public Iterator()
        {
        }
    }

    public class Context : IDisposable
    {
        private readonly StringBuilder log = null;
        public Context(StringBuilder log)
        {
            this.log = log;
            this.log.AppendLine("Context created");
        }
      
        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: eliminar el estado administrado (objetos administrados)
                }

                // TODO: liberar los recursos no administrados (objetos no administrados) y reemplazar el finalizador
                // TODO: establecer los campos grandes como NULL
                disposedValue = true;
            }
        }

        // // TODO: reemplazar el finalizador solo si "Dispose(bool disposing)" tiene código para liberar los recursos no administrados
        // ~Context()
        // {
        //     // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en el método "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);

            this.log.AppendLine("Context disposed");
        }
    }

}
