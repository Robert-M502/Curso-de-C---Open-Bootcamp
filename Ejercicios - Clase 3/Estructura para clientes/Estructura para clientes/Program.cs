/* Crea una estructura de datos para un cliente con estos campos:
Nombre completo, Teléfono, Dirección, Email y  Si es nuevo cliente 
Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...) */


Clientes clientes = new Clientes("Roberto Morales", 34567654, "Tecpán Guatemala", "roberto@gmail.com", true);
Console.WriteLine("Nombre Completo: " + clientes.NombreCompleto);
Console.WriteLine("Teléfono: " + clientes.Telefono);
Console.WriteLine("Dirección: " + clientes.Direccion);
Console.WriteLine("Email: " + clientes.Email);
Console.WriteLine("Nuevo cliente: " + clientes.NuevoCliente);

public struct Clientes
{
    public Clientes(string nombreCompleto, int telefono, string direccion, string email, bool nuevoCliente) 
    {
        NombreCompleto = nombreCompleto;
        Telefono = telefono;
        Direccion = direccion;
        Email = email;
        NuevoCliente = nuevoCliente;
        

    }
    public string NombreCompleto { get; set; }
    public int Telefono { get; set; }
    public string Direccion { get; set; }
    public string Email { get; set; }
    public bool NuevoCliente { get; set; }

    public override string ToString() => $"({NombreCompleto}, {Telefono}, {Direccion}, {Email}, {NuevoCliente})";

}