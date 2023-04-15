// Crear archivos TXT y realizar operaciones
using System.IO;

string texto;

// Escribir en un archivo TXT
try {
    StreamWriter sw = new StreamWriter("miArchivo.txt", true);
    sw.WriteLine("Añado esta línea");
    sw.WriteLine("Añado esta otra línea");
    sw.Close();
}
catch (Exception ex) {
    Console.WriteLine("Ha ocurido un error: " + ex);
}

// Leer un archivo en la carpeta del Archivo
try
{
    StreamReader sr = new StreamReader("miArchivo.txt");
    var linea = sr.ReadLine();
    while (linea != null)
    {
        Console.WriteLine(linea);
        linea = sr.ReadLine();
    }
    sr.Close(); // Cerramos el string asociado al archivo
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine("Ha ocurido un error: " + ex.Message);
}
finally
{
    Console.WriteLine("Final del try-catch-finally.");
}

/* Operaciones con archivos:
- Crear archivo 
- Leer -> no modifica el contenido // modo lectura
- Escribir -> si modifica y borra lo anterior // modo escritura
- Append -> Escribe añadiendo contenido al final // modo append -> log
 */