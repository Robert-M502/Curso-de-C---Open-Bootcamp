// Sumar los 100 primeros números enteros
int i = 0;
int suma = 0;
for (i=0; i<=100; i++) {
    suma += i;
}
Console.WriteLine(suma + "\n"); //5050

// Expandimos el código para que el usuario indique un numero hasta donde vamos a sumar
int j = 0;
int resultado = 0;
int limite = 0;
Console.WriteLine("Introduce el limite de la suma");
limite = Convert.ToInt32(Console.ReadLine());
for (j=0; j<=limite; j++)
{
    resultado += j;
}
Console.WriteLine($"Resultado: {resultado} \n");

// Escribir todos los elementos de un array
int[] arr = new int[3];
arr[0] = 1;
arr[1] = 2;
arr[2] = 3;

Console.WriteLine("FOR: ");
for (i=0; i<arr.Length; i++) {
    Console.Write(arr[i] + " ");
}

Console.WriteLine("\nFOREACH: ");

foreach (var item in arr) {
    Console.Write(item + " ");
}

Console.WriteLine("\nWHILE: ");
i = 0; 
while (i < arr.Length) {
    Console.Write(arr[i] + " ");
    i++;
}