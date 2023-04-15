// Main
Puerta door = new Puerta();
door.CambiarAlto(200.5f);
door.Abrir();
door.MostrarEstado();
door.Cerrar();
door.MostrarEstado();

// End Main

public class Puerta {
    int ancho;
    float alto;
    string color;
    string material = "madera";
    bool abierta;

    public void CambiarAlto(int n) {
        alto = n;
    }

    public void CambiarAlto(float f) {
        // alto = Convert.ToInt32(f);
        alto = f;
    }

    public void PintarPuerta(string color) {
        this.color = color;
    }

    public void Abrir() {
        abierta = true;
    }

    public void Cerrar() {
        abierta = false;
    }

    public void MostrarEstado() {
        Console.WriteLine("Ancho: {0}", ancho);
        Console.WriteLine("Alto: {0}", alto);
        Console.WriteLine("Color: {0}", color);
        Console.WriteLine("Material: {0}", material);
        Console.WriteLine("Abierta: {0}", abierta);
    }
}