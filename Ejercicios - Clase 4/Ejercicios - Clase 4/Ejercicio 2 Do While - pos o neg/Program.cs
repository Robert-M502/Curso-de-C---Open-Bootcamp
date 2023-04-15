/* Escribe un programa que realice estos pasos:
Reciba al menos un número por consola
Determine si el número es positivo o negativo
Presente un contador para cada tipo (positivo y negativo).
Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. Tienes completa libertad para elegir el formato de la salida. */

int positivos = 0;
int negativos = 0; 
int ceros = 0;
string entrada;

do {
    Console.WriteLine("Introduce un numero, para finalizar introduce una letra: ");
    entrada = Console.ReadLine();
    if (!int.TryParse(entrada, out int numero)) {
        break;
    }
    if (numero > 0) {
        positivos++;
    } else if (numero < 0) {
        negativos++;
    } else {
        ceros++;
    }

} while (true);

Console.WriteLine($"Numeros positivos {positivos}");
Console.WriteLine($"Numeros positivos {negativos}");
Console.WriteLine($"Numeros positivos {ceros}");
