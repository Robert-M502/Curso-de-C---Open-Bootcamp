// Main

CalcularAprobado(1);
CalcularAprobado(5);
CalcularAprobado(9);

// Scope, Contexto
int i = 2;
Console.WriteLine("i desde Main: " + i);
EntendidendoScope(i);

// Funciones anónimas
int[] numbers = { 2, 3, 4, 5 };
var squaredNumbers = numbers.Select(x => x * x);
Console.WriteLine(string.Join(" ", squaredNumbers));

// End Main

int EntendidendoScope(int a)
{
    //int i = 1;
    a = a + 2;
    Console.WriteLine("i desde fun: " + a);
    return a;
}

// Void no devuelve un valor
void CalcularAprobado(int a) {
    if (a < 5)
    {
        Console.WriteLine("Has suspendido :(");
    }
    else if (a == 5)
    {
        Console.WriteLine("Aprobado respado");
    }
    else {
        Console.WriteLine("Has aprobado");
    }
}


