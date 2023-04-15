//Bucles

// While - código mientras la condición sea true
int i = 1;

Console.WriteLine("----------- WIHLE -----------");
while (i <= 10) {
    Console.Write(i + " ");
    i++;
}
Console.WriteLine("\n Despues del While: " + i);

// For - para / por
Console.WriteLine("----------- FOR -----------");

for (int j=0; j<=10; j++) {
    Console.Write(j + " ");
}

// Do While - hacer... mientras
Console.WriteLine("\n ----------- DO WIHLE -----------");
i = 5;
do {
    Console.Write(i + " ");
    i+=5;
}
while (i<50);


// Foreach - para/por cada
Console.WriteLine("\n ----------- FOREACH -----------");
var lista = new List<string> {"Roberto", "Sebastián", "Alexander", "Manuel"};

foreach (var elemento in lista) {
    Console.WriteLine(elemento);
}


