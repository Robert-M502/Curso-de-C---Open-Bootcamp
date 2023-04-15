Console.WriteLine(Estaciones.Verano);
Console.WriteLine((int)CodigoDeError.SinConexion);

enum Estaciones { 
    Verano,
    Primavera, 
    Otoño,
    Invierno
}

enum CodigoDeError : ushort { 
    Ninguno = 0,
    Desconocido = 1,
    SinConexion = 180
}