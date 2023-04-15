using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Situaciones inesperadas -> no deseada -> "error"
// try, carch, finally

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"1 entre 2: {DivisionSegura(1,2)}"); // Comprobamos que funciona
            try {
                Console.WriteLine($"1 entre 0: {DivisionSegura(1, 0)}"); // Nan -> no es un número
            }
            catch (Exception ex) {
                Console.WriteLine($"Error. Ha ocurido esto: {ex.Message}");
            }
            // Continuamos con el progrma si capturamos la excepción (catch)
            Console.WriteLine($"1 entre 3: {DivisionSegura(1, 3)}"); // Comprobamos que funciona
            int[] arr = new int[3];
            arr[0] = 0;
            arr[1] = 1;
            arr[2] = 2;
            try
            {
                Console.WriteLine(arr[3]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally {
                Console.WriteLine("¿Es correcto el valor que aparece?");
                // Lógica para que el usuario verifique si el valor es correcto
            }
            Console.WriteLine("Fin del programa");

            /* Tipos 
            * Exception -> Clase base de las excepciones
            * IndeOutOfRangeException-> Se intentó un elemento que no existe en un array, etc.
                string str = "atring";
                str.Substring(0, str.Length + 1);
            * NullReferenceException -> Se pidió un objeto null
                object obj = null;
                obj.ToString();
            * ArgumentException-> Clase base para Excepciones relacionadas con argumentos
                string str = null;
                str.Substring(0, 2);
            */



            Console.ReadKey();
        }

        static double DivisionSegura(double a, double b) {
            if (b == 0) {
                throw new DivideByZeroException();
                //throw new UsuarioNoEncontradoException();
            }
            return a/b;
        }
    }
}
