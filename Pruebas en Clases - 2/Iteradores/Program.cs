using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Iteradores  -> Collections, List, Arrays
/* Aplicar una operación/acción a cada elemento
 * Enumerar una lista 
 * LINQ -> query o consulta
 * Canlizar los datos a otr proceso
 */

namespace Iteradores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sync
            List<string> lista = new List<string> { "Item 1", "Item 2", "Item 3", "Item 4" };
            foreach (var item in lista) {
                Console.WriteLine(item.ToString());
            }
            // Async
            /*
            await foreach (var item in lista)
            {
                Console.WriteLine(item.ToString());
            }
            */
            

        }
        IEnumerable<int> NumerosEnteros() {
            yield return 1; 
            yield return 2; 
            yield return 3;
        }

        IEnumerable<int> EscribirNumeroEnteros() {
            int index = 0;
            while (index < 3) 
                yield return index++;
            
        }
        /*
        async IAsyncEnumerable<int> EscribirNumerosAsync() {
            int index = 0;
            while (index < 1)
                yield return index++;
                await Task.Delay(1000);
            while (index < 3)
                yield return index++;
            //
        }
        */
    }
}
