// Main

// Clase puerta
Puerta door = new Puerta(150, 200, 0000);
door.MostrarEstado();

Puerta door2 = new Puerta();
door2.MostrarEstado();

Console.WriteLine(door2.ancho);

// Clase persona
Persona persona = new Persona();

Console.WriteLine(Persona.experiencia); // Static -> acceder a un atributo estático
Persona.Experiencia(); // Static -> acceder a un método estático

// Declarando un objeto
persona.nombre = "Robert";
persona.fechaNacimiento = Convert.ToDateTime("25/08/2000");
persona.registrar();

// Clase alumno
Alumno alumno = new Alumno();
alumno.Nombre = "Robert";
alumno.FechaNacimiento = Convert.ToDateTime("25/08/1999");
alumno.registrar();

// End main

// Encapsulamiento -> niveles de modificadores de acceso: public, protected, private
public class Puerta {
    // Atributos
    public int ancho;
    int alto;
    int color;
    bool abierta;

    // Constructor 
    public Puerta(int ancho = 100, int alto = 100, int color = 0, bool abierta = true)
    {
        this.ancho = ancho;
        this.alto = alto;
        this.color = color;
        this.abierta = abierta;
    }
    public void MostrarEstado() {
        Console.WriteLine($"Ancho  {ancho}");
        Console.WriteLine($"Alto {alto}");
        Console.WriteLine($"Color {color}");
        Console.WriteLine($"Abierta {abierta}\n");
    }

    // Destructor
    ~Puerta() { // Codigo que se ejecuta cuando se destruye una puerta
        Console.WriteLine("La puerta se ha destruido");
    }
}

// Clase persona con encapsulamiento más abierto
public class Persona {
    // Atributos
    public static string experiencia = "C#";
    public string nombre;
    public DateTime fechaNacimiento;
    private int edad;

    // Métodos
    public void registrar() {
        calcularEdad(fechaNacimiento);
        Console.WriteLine($"{nombre} con {edad} años de edad, ha sido registrado correctamente\n");
    }
    public void calcularEdad(DateTime fechaNacimientoPersona) {
        DateTime fechaActual = DateTime.Now;
        edad = fechaActual.Year - fechaNacimientoPersona.Year;
    }
    public static void Experiencia() {
        Console.WriteLine("Progrmación en C#");
    }
}

// Clase Alumno con encapsulamiento más cerrado
public class Alumno
{
    // Atributos
    private string _nombre;
    private DateTime _fechaNacimiento;
    private int _edad;
    // Propiedades
    public int Edad {
        get
        {  // Encapsulación nivel abiert, por defecto es publico porque la propiedad es publico 

            return _edad;

        }
        set { // Encapsulamiento nivel cerrado _Privado
            _edad = value;
        }
    }

    public string Nombre {
        get {
            return _nombre;
        }
        set {
            _nombre = value;
        } 
    }
    public DateTime FechaNacimiento
    {
        get
        {
            return _fechaNacimiento;
        }
        set
        {
            _fechaNacimiento = value;
        }
    }
    // Métodos
    public void registrar()
    {
        calcularEdad(FechaNacimiento);
        Console.WriteLine($"{Nombre} con {Edad} años de edad, ha sido registrado correctamente\n");
    }
    public void calcularEdad(DateTime fechaNacimientoPersona)
    {
        DateTime fechaActual = DateTime.Now;
        Edad = fechaActual.Year - fechaNacimientoPersona.Year;
    }
}

