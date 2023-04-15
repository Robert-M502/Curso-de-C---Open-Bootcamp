using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Depuración o Debuggin, Debug
// Bug -> "error", "typo", "resultado incorrecto", etc.

namespace Depuracion_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu mensaje");
            var msg = Console.ReadLine();
            Console.WriteLine($"He recibido este mensaje: {msg}");
            int resultado = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i=0; i<10; i++) {
                resultado = i * 2 + 1;
                Console.WriteLine(resultado); 
                // Opracion que queremos controlar
            }
            sw.Stop();
            var tiempo = sw.Elapsed;
            Console.ReadKey();
        }
    }
}


/* Notas 
 * Cómo podemos depurar un programa 
 * Resolución de errores
 * Herrramientas para depurar
 */

