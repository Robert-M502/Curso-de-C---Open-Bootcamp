using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Delegados -> referencia a un meétodo := variable --> método
 * <modificadore de acceso> delegate <tipo de retorno> <nombre> (<parametros>)
 *  public      delegate    void    ImprimirDocDelegado(string path) {};  
 *  Delegados disponibles por defectos 
 *  - Action<T>         -> siempre devuelve void, de 0 a 16 params de tipo Generics
 *                       ->  Action<string> -> recibe string, devuelve void
 *  - Anónimos  -> Definir con sintaxis lambda
 *  - Func<in T, out TResult>       -> Func, string> -> recibe int y retorna string
 *  - Predicate<T>                  -> Siempre devuelve un boolean
 */

namespace Deelegados
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usando el delegao que hemos declarado con "... delegate void"
            Console.WriteLine("Escribe un mensaje para el delgado: ");
            string msg = Console.ReadLine();
            ImprimirDelegadoClass obj = new ImprimirDelegadoClass();
            obj.EjemploDelegate(msg);

            // Usando Action<string>
            Console.WriteLine("\n------- Action -------");
            Console.WriteLine("Escribe un mensaje para Action: ");
            string msg2 = Console.ReadLine();

            ImprimirConActionClase obj2 = new ImprimirConActionClase();
            obj2.EjemploAction(msg2);

            // Usando Delegado anónimo 
            Console.WriteLine("\n------- A´nónimo -------");
            ImprimirConDelegadoAnonimo obj3 = new ImprimirConDelegadoAnonimo();
            string msg3 = Console.ReadLine();
            obj3.EjemploConDelegadoAnonimo(msg3);
        }
    }

    public delegate void ImprimirDelegado(string value);

    public class ImprimirDelegadoClass {
        private void Imprimir(string value) {
            Console.WriteLine($"He recibido este valor: {value}");
        }
        public void EjemploDelegate(string str) {
            // Declaración
            ImprimirDelegado imprimirDelegado = new ImprimirDelegado(Imprimir); // Recibe el método imprimir
            // Invocación - call
            imprimirDelegado(str);
        }
    }

    // Action
    public class ImprimirConActionClase {
        private void Imprimir(string msg) {
            Console.WriteLine(msg);
        }
        public void EjemploAction(string msg)
        {
            Action<string> imprimirDelegadoAction = Imprimir;
            imprimirDelegadoAction(msg);
        }
    }

    // Anónimo
    public class ImprimirConDelegadoAnonimo
    {
        // Definición estandar
       
        public void EjemploConDelegadoAnonimo(string msg) {
            /*
           Action<string> imprimirConAction = delegate (string msga)
           {
               Console.WriteLine($"Desde delegado anónimo: {msga}");
           };
       */
            // Definición con lambda
            Action<string> imprimirConActionLambda = x => Console.WriteLine($"Desde delegado anónimo con lamda: {x}");
            // imprimirConAction(msg);
            imprimirConActionLambda(msg);

            // Func
            Func<int, string> resultado = v => $"El resultado es: {v}";
            Console.WriteLine(resultado(5));

            Func<int, int, int> multiplicar = (v1, v2) => v1 * v2;
            int producto = multiplicar(3, 2);
            Console.WriteLine(producto);

            // Predicate
            Predicate<int> esMayorDeEdad = e => e >= 18;
            bool mayorDeEdad = esMayorDeEdad(21); // true
        }
    }
}

// Notas