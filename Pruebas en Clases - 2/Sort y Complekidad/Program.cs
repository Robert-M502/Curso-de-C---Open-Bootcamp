using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Sort

namespace Sort_y_Complekidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce número de elementos: ");
            var N = Convert.ToInt32(Console.ReadLine()); 
            int[] arr = new int[N];

            for (int i=0; i<N; i++) {
                arr[i] = 1;
            }
            Stopwatch crono = new Stopwatch();
            crono.Start();
            for (int j=0; j<N; j++) {
                for (int k=N-1; k>0; k--) {
                    arr[k] = j + k;
                }
            }
            crono.Stop();
            Console.WriteLine($"Para {N} elementos, se tarda: {crono.Elapsed}");
            
            /* N        Complejidad N^2
             * 1000     00:00:00.0035691
             * 10000    00:00:00.2189234
             * 100000   00:00:39.2289567
             */
        }
    }
}


/* Notas
 * Formas de ordenar un array en c#
 * - Algoritmos -> serie de pasos ordenados para resolver un problema
 * - Sort -> ordenar un conjunto de elemntos en un array
 * Que es la complejidad
 * - Tiempo -> número de ciclos
 * - Espacio -> tamaño del programa ~ n
 */ 
