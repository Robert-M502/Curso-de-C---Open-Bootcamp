using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Indizadores -> Indexadores 
// Recurso que nos permite acceder a una estructura de datos de tipo matriz

namespace Indizadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo del array de Temperaturas
            var TemperaturasDiarias = new Temperaturas();
            TemperaturasDiarias[1] = 11.5f;
            TemperaturasDiarias[9] = 8.5f;

            // Ver los datos
            for (int i = 0; i < TemperaturasDiarias.len; i++) {
                Console.WriteLine($"Item: {TemperaturasDiarias[i]}");
            }

            // Ejemplo con Dias de la semana
            var semana = new DiasSemanas();
            Console.WriteLine(semana["Domingo"]);
            try {
                Console.WriteLine(semana["Asad"]);
            } catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
   
    // Declaración del indizadore
    public class Temperaturas
    {
        float[] temp = new float[10]
        {
            10F, 11f, 9f, 11f, 10f,
            11f, 10f, 11f, 15f, 8f
        };
        public int len => temp.Length;

        // Indizador
        public float this[int index] {
            get => temp[index];
            set => temp[index] = value;
        }
    }
    class DiasSemanas {
        public string[] dias = {
        "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sabado", "Domingo"
        };
        public int this [string dia] => FindDayIndex(dia);
        private int FindDayIndex(string dia) {
            for (int j = 0; j < dias.Length; j++) {
                if (dias[j] == dia) {
                    return j;
                }
            }
            // Exception
            throw new ArgumentOutOfRangeException(
                nameof(dia),
                $"El día {dia} no está en la lista. Comprueba si está bien escrito."
                );
        }
    }
}
