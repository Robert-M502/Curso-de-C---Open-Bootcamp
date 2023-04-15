/*
 Inicializar objetos
- Crar obj -> pasar params
- Crar obj -> cambiar valores
- Constructor del obj
 */




//Tipos Anónimos
// Car coche = new Car(); No anónimo
var coche = new { Marca = "Ford", Año = "2021" };
Console.Write($"Tengo un coche marca {coche.Marca} del año {coche.Año}\n");

MostrarDatos("dato");

// End main 

void MostrarDatos(string dato) {
    var myVar = coche.Marca;
    Console.WriteLine(myVar + dato);
}