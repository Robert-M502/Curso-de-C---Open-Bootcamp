Console.WriteLine("Que dia es hoy?");
string dia = Console.ReadLine().ToUpper();

// Bucle if... else
Console.WriteLine("\n------ IF ELSE ------");

if (dia == "lunes") {
    Console.WriteLine("Feliz Lunes");
} else
{
    Console.WriteLine("Hoy no es lunes");
} 

// Switch
Console.WriteLine("\n------ SWITCH ------");

switch (dia) {
    case "LUNES":
        Console.WriteLine("Hoy es lunes");
        break; 
    case "MARTES":
        Console.WriteLine("Hoy es martes");
        break;
    case "MIERCOLES":
        Console.WriteLine("Hoy es miercoles");
        break;
    case "JUEVES":
        Console.WriteLine("Hoy es jueves");
        break;
    case "VIERNES":
        Console.WriteLine("Hoy es viernes");
        break;
        // Resto de los dias de la semana
    default:
        Console.WriteLine("Ese no es un día de la semana");
        break;
}

// Break 
Console.WriteLine("\n------ BREAK ------");
if (dia == "LUNES") {
    for (int i=0; i<=3; i++) {
        Console.WriteLine("Lunes");
        break; // Detiene la ejecución del bucle
    }
    Console.WriteLine("Después del brak");
}

// Continue
Console.WriteLine("\n------ CONTINUE ------");
for (int z=0; z<=10; z++) {
    Console.WriteLine(z);
    if (z<5) {
        Console.WriteLine("x es menor que 5");
        continue;
    }
}

