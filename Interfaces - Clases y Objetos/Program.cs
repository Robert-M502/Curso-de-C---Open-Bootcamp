// Usos de Interfaces
var persona = new Persona();
//persona.PreguntarNombre();
//Console.WriteLine($"Su nombre es: {persona.Nombre}");

// End main

// Plantilla o contrato que hay que cumplir  
public interface IPersonas { 
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { set; get; }
    public bool EnActivo { get; set; }
    public DateOnly FechaNacimiento { get; set; }
    public void PreguntarDatos();
    public void EscribirDatos();
}

// Implementación
public class Persona : IPersonas
{
    // Tipo Constructor 
    public Persona()
    {
        PreguntarDatos();
        EscribirDatos();
    }

    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public bool EnActivo { get; set; }
    public DateOnly FechaNacimiento { get; set; }
 
    public void PreguntarDatos() {
        Console.WriteLine("¿Cual es tu nombre?");
        var nombre = Console.ReadLine();
        if (nombre == null) {
            Console.WriteLine("Mensaje cuendo no se introdujo nombre");
        } else {
            Nombre = nombre;
        }

        Console.WriteLine("¿Cual es tu fecha de nacimiento (aaa/mm/dd)?");
        var fecha = Console.ReadLine();
        FechaNacimiento = DateOnly.Parse(fecha);
    }
    public void EscribirDatos() {
        Console.WriteLine($"Nombre: {Nombre}, Fecha de Nacimiento: {FechaNacimiento}");
    }

}