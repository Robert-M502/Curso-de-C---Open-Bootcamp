// Métodos
// Main

Motos.ArrancarMotos(); //Método static
Carros.ArrancarCarros(); //Método static

var moto = new Motos();
moto.ArrancarMoto();

// Extension -> Un clase desde otro archivo
Metodos.ExtensionMoto.Acelerar();

// Retornos de métodos
int gasolina = moto.CantidadGasolina();
Console.WriteLine("Cantidad de gasolina: " + gasolina + " litros de combustible");

// Sobrecarga
dynamic nivelDeposito = moto.EcharGasolina(5.5f); // dynamic selecciona la funcion segun el tipo de variable
Console.WriteLine("Ahora tenemos: " + nivelDeposito + " litros de combustible");

// Definición

// End Mian 

class Motos {
    public static void ArrancarMotos(){ //Método de la clase motos
        Console.WriteLine("Arranca motos");
    }

    public void ArrancarMoto() {
        Console.WriteLine("Arranco esta moto");
    }

    public int CantidadGasolina() {
        int gasolina = 20; 
        return gasolina;
    }
    public int EcharGasolina(int litros) {
        int nivelDeposito = 20 + litros;
        return nivelDeposito;
    }
    public float EcharGasolina(float litros) {
        float nivelDeposito = 20 + litros;
        return nivelDeposito;
    }
}

class Carros
{
    public static void ArrancarCarros() // No es necesario crear un objeto con static se usa la misma clase
    { //Método de la clase motos
        Console.WriteLine("Arrancar caros");
    }
}