// Areglos
string [] names = new string[2]; //(1,2)
names[0] = "Robert";
names[1] = "Sebastián";

foreach (string elemento in names) {
    Console.WriteLine(elemento);
}

for (int i=0; i<names.Length; i++) {
    Console.WriteLine(names[i]);
}

int[] numbers = { 6, 5, 4, 7, 3};
Array.Sort(numbers); // Ordenamos el array de int
foreach (int numeros in numbers) {
    Console.Write(numeros);
}

// Más tipos de Arrays
int[,] miArray2D = new int[2, 2];   // 1 3
                                    // 4 4
miArray2D[0, 0] = 1;
miArray2D[0, 1] = 2;
miArray2D[1, 0] = 3;
miArray2D[1, 1] = 4;

Console.WriteLine("\n" + miArray2D.Length + "\n"); //4

for (int k=0; k<2; k++) { 
    for (int l = 0; l < 2; l++)
    {
        Console.WriteLine(miArray2D[k, l]);
    }
}




