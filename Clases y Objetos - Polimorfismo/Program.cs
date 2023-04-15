// Polimorfismo - Distintas salidas para métodos en función de los parámetros u objtos
// Main
Vehiculo vehiculo = new Vehiculo();
vehiculo.Arrancar();

Coche coche = new Coche();
coche.Arrancar(); // Arrancar es un metodo de la clase vehiculo que esta herredado a coche
coche.DetenerCoche();
coche.Arrancar("Robert");

// End main 

// Clase parent o padre
class Vehiculo
{
    public float combustible { get; set; }
    public int aforo { set; get; }
    public void Arrancar()
    {
        Console.WriteLine("Este vehiculo ha arrancado");
    }
}

// Clase child o hija
class Coche : Vehiculo
{
    public int ruedas { get; set; }
    public void DetenerCoche()
    {
        Console.WriteLine("El coche se ha detenido");
    }
    // Sobre Carga de metodo
    public void Arrancar()
    {
        Console.WriteLine("Este vehiculo ha arrancado con éxito");
    }
    public void Arrancar(string str) {
        Console.WriteLine($"{str} ha arrancado este coche a las {DateTime.Now.ToShortTimeString()}");
    }
}