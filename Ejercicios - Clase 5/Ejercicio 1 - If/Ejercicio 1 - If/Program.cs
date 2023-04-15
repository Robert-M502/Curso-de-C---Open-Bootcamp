/* Escribe un programa que:
Pida datos a un cliente: Nombre, email, cupón
Determine si un cliente tiene un cupon descuento
Muestre un precio rebajado en función del descuento
Muestre el precio de un producto sin descuento si no hay cupón
Nota: puedes poner un precio fijo de un producto o uno variable. */

string nombre;
string email;
bool cupon;

Console.Write("Ingresa tu nombre: ");
nombre = Console.ReadLine();
Console.Write("Introduce tu correo electrónico: ");
email = Console.ReadLine();
Console.Write("Tienes un cupo de descuento (true/false): ");
cupon = Convert.ToBoolean(Console.ReadLine());

if (cupon)
{
    double precio = 50;
    double descuento = 10;
    double precioFinal = precio * (100 - descuento) / 100;
    Console.WriteLine($"{nombre} el precio final del producto con un {10}% de descuento es: ${precioFinal}");
}
else {
    double precio = 50;
    Console.WriteLine($"{nombre} el precio final del producto sin descuento es: ${precio}");
}
