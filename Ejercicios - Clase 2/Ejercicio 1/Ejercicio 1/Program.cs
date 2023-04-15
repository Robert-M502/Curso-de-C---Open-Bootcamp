/*Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable 
 * para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.*/

string nombre;
string apellido;
int edad;
string texto;

Console.WriteLine("Ingrese su nombre");
nombre = Console.ReadLine();
Console.WriteLine("Ingrese su apellido");
apellido = Console.ReadLine();
Console.WriteLine("Ingrese su edad");
edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sabes programar");
texto = Console.ReadLine();

Console.WriteLine("Su nombres y apellido es: " + nombre + " " + apellido + " tiene " + edad + " años");
Console.WriteLine("Y " + texto + " sabe programar");