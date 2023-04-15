// LINQ? -> Language Integrated Query
// Obtener datos que despues vamos a utilizar en nuestro programa

// Obtener el origen de los datos, ej: archivo, DDBB, etc,
int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
string[] str = new string[5] { "Robert", "Alexander", "Juana", "Lucas", "Manuela" };

// Crear la consulta con una consulta
var consulta =
    from numero in numbers
    where (numero % 2) == 0
    select numero;

// Ejecutar la consulta
foreach (var num in consulta) {
    Console.Write(num + " ");
}

// Ejemplos
// Seleccionar numeros pares
Console.WriteLine("\nNúmeros pares");
var pares =
    from numero in numbers
    where (numero % 2) == 0
    select numero;
foreach (var num in pares)
{
    Console.Write(num + " ");
}

// Seleccionar numeros impares
Console.WriteLine("\nNúmeros impares");
var impares =
    from numero in numbers
    where (numero % 2) != 0
    select numero;
foreach (var num in impares)
{
    Console.Write(num + " ");
}

// Determinar número mayor que 5 y menor que 9
Console.WriteLine("\nNúmeros impares");
var nums =
    from numero in numbers
    where (numero > 5 && numero <= 8)
    select numero;
foreach (var num in nums)
{
    Console.Write(num + " ");
}

//
Console.WriteLine("\nNombres");
var nombres =
    from elem in str
    where (elem.Length > 5)
    select elem;
foreach (var elemento in nombres)
{
    Console.Write(elemento + " ");
}
