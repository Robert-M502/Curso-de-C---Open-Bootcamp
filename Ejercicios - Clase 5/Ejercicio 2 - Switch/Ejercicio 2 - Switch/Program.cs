/* Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++. Presenta la lista en 
consola y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. 
Presenta el resultado en consola.
Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#. */

string[] arra = new string[4];
arra[0] = "C#";
arra[1] = "Php";
arra[2] = "JavaScript";
arra[3] = "Python";

Console.WriteLine("Listado de lenguajes de programación");
for (int i=0; i<arra.Length; i++) {
    Console.WriteLine($"{i+1} {arra[i]}");
}

Console.Write($"Selecciona una ópción (1-4 a a-d)");
string opcion = Console.ReadLine().ToLower();

switch (opcion) {
    case "1":
    case "a":
        Console.WriteLine($"Hala mundo desde: {arra[0]}");
        break;
    case "2":
    case "b":
        Console.WriteLine($"Has seleccionado el lengueje {arra[1]}");
        break;
    case "3":
    case "c":
        Console.WriteLine($"Has seleccionado el lengueje {arra[2]}");
        break;
    case "4":
    case "d":
        Console.WriteLine($"Has seleccionado el lengueje {arra[3]}");
        break;

    default:
        Console.WriteLine("La opción no esta en el listado");
        break;
}
