// Operadores básicas
// Aritméticos + - * / % -- ++
Console.WriteLine("--------- ARITMÉTICAS ---------");
int i = 0;
Console.WriteLine("Suma: " + (i+1));
Console.WriteLine("Autoincremento: " + ++i);
Console.WriteLine("Autodecremento: " + --i);
Console.WriteLine("División: " + i/4); // El resultado es entero

// Operadores de asignación
Console.WriteLine("--------- ASIGNACIÓN ---------");

int j = 2;
// j = j + 3;
Console.WriteLine("Sumo 3: " + (j+=3));
Console.WriteLine("j: " + j);

// Operadores de compración
Console.WriteLine("--------- COMPRACIÓN ---------");

int k = 1;
Console.WriteLine("Iguales? " + (j==k));
Console.WriteLine("j mayor? " + (j>k));
Console.WriteLine("j menor? " + (j<k));

// Operadores lógicos
Console.WriteLine("--------- LÓGICOS ---------");

// Y - AND
int a = 9;
int b = 11;
Console.WriteLine("True True: " + (a<10 && b<12));
Console.WriteLine("False True: " + (a>10 && b<12));
Console.WriteLine("True False: " + (a<10 && b>12));
Console.WriteLine("False False: " + (a>10 && b>12));
// O - R
Console.WriteLine("True True: " + (a<10 || b<12));
Console.WriteLine("False True: " + (a>10 || b<12));
Console.WriteLine("True False: " + (a<10 || b>12));
Console.WriteLine("False False: " + (a>10 || b>12));
// NO - NOT
Console.WriteLine("True " + !(a<10));
Console.WriteLine("False " + !(a > 10));