// Colecciones 

// Coleccion de strings
using System.Linq.Expressions;

var coches = new List<string>();

coches.Add("Ford");
coches.Add("BMW");
coches.Add("Peugeot");

var choches2 = new List<string> { "Seat", "Volkswager", "Fiat" };

foreach (var element in coches) {
    Console.Write(element + " ");
}

List<Elemento> elemento = CrearLista();

var query = from el in elemento
         where el.NumeroAtomico < 20
         select el;

foreach (Elemento el in query) {
    Console.Write($"\nNombre: {el.Nombre}, Símbolo: {el.Simbolo}, Númeor atómico: {el.NumeroAtomico}");
}

// End Main

static List<Elemento> CrearLista() {
    return new List<Elemento> {
        {new Elemento() {Simbolo = "K", Nombre = "Postasio", NumeroAtomico = 19} },
        {new Elemento() {Simbolo = "Ca", Nombre = "Calcio", NumeroAtomico = 20} },
        {new Elemento() {Simbolo = "Ti", Nombre = "Titanio", NumeroAtomico = 22} }
    };
}

public class Elemento { 
    public string Simbolo { get; set; }
    public string Nombre { get; set; }
    public int NumeroAtomico { get; set; }
}

