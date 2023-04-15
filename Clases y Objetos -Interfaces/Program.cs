// Interfaces - clases que definen artibutos, métodos, etc. sin impletar
// Main
Vehiculo vehiculo = new Vehiculo();
vehiculo.Marca = "Ford";
Console.WriteLine();

// End main

interface IVehiculo
{
    void Arrancar();
    public string Marca { get; set; }
}

class Vehiculo : IVehiculo {
    public string Marca { get; set; }
    public void Arrancar() {
        Console.WriteLine("Arrancar");
    }
}


