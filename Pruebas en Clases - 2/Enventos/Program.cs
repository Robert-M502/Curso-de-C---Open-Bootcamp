using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Algo que ocure y que desencade acciones
// Eventos de google := editor -> suscriptor


namespace Enventos
{
    class Program
    {
        static void Main(string[] args)
        {
            SuscriptorCalc calculadora = new SuscriptorCalc(1, 2);
            calculadora.ResultadoSuma();
            calculadora.ResultadoResta();         
        }
    }

    /* Editor o publisher
    * Determina cuando se lanza el evento
    * Definicion del evento
    * Delegado 
    */
  
    public class EditorCalc
    {
        public delegate void EjemploDelegado();
        public event EjemploDelegado ejemploEvento;

        public void Sumar(int a, int b)
        {
            if (ejemploEvento != null)
            {
                ejemploEvento();
                Console.WriteLine($"La suma es: {a + b}");
            }
            else
            {
                Console.WriteLine("No tienes una suscripción al evento.");
            }
        }
        public void Restar(int a, int b)
        {
            if (ejemploEvento != null)
            {
                ejemploEvento();
                Console.WriteLine($"La resta es: {a - b}");
            }
            else
            {
                Console.WriteLine("No tienes una suscripción al evento.");
            }
        }
        public void Saludar() {
            if (ejemploEvento != null)
            {
                ejemploEvento();
                Console.WriteLine("Hola");
            }
            else {
                Console.WriteLine("No tienes una suscripción al evento.");
            }
        }
    }

    /* Suscriptor 
    * Acepta el evento y proveé un event handler, es decir 
    * Método que será ejecutado cuando ocurra el evento
    */
    public class SuscriptorCalc {
        EditorCalc editor;
        private readonly int A;
        private readonly int B;

        public void EjemploEventHandler() {
            Console.WriteLine("Se imprime el resultado de la operación: ");
        }
        public SuscriptorCalc(int a, int b) {
            editor = new EditorCalc();
            A = a;
            B = b;
            editor.ejemploEvento += EjemploEventHandler; // Habilitar la suscripción
        }
        public void ResultadoSuma() {
            // métodos
            editor.Sumar(A, B);
        }
        public void ResultadoResta() {
            // métodos
            editor.Restar(A, B);
            editor.Saludar();
        }
    }
}

/* Notas 
 * Como gestionar eventos
 * Recordemos:
 * palabra clave "event" junto con delegado
 * comprobar que evento no sea NULL antes de ejecutar para evitar errores
 * Suscribir += y darse de baja con -=
 * Ejecutar evento -> llamada a delegado
 * Eventos pueden existir en interfaces
 * Eventos -> interfaces gráficas -> web (botones, etc.)
 */
