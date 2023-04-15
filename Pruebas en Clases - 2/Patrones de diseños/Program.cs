using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Patrones de Diseños


namespace Patrones_de_diseños
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton2 s1 = Singleton2.GetInstance();
            Singleton2 s2 = Singleton2.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton funciona");
            }
            else {
                Console.WriteLine("Singleton falló, las instacias son distintas");
            }
        }
    }

    // Singleton -> Logger
    public sealed class Singleton2 {
        static Singleton2() { }
        private static Singleton2 _instance;
        public static Singleton2 GetInstance() {
            if (_instance == null) {
                _instance = new Singleton2();
            }
            return _instance;
        }
        public static void miMetodo() {
            Console.WriteLine("Hola desde miMetodo");
            // operaciones, lógica, etc.
        }
    }
}
