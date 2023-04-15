/* Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola */

int num = 0;
int i = 1;
int resultado = 0;

Console.WriteLine("Ingrese un numero: ");
num = Convert.ToInt32(Console.ReadLine());

while (i <= 10) {
    resultado = num * i;
    Console.WriteLine($"{num} x {i} = {resultado}");
    i++;

}