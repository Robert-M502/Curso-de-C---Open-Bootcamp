// Main 
float f = 3.1415f;
EscribirNumeroReal(f);

SumaDeNumerosRales(3.1415f, 3.1415f);

/*for (int i=0; i<=5; i++) {
    long resultado = CalcularFactoria(i);
    Console.WriteLine(resultado);
} */
Console.WriteLine(CalcularFactoria(4));

// End Main

static void EscribirNumeroReal(float n) {
    Console.WriteLine(n.ToString("#.###")); // Formatear el numero con solo 3 decimales
}

void SumaDeNumerosRales(float a, float b) {
    float resultado = a + b;
    Console.WriteLine(resultado.ToString("#.#"));
}

// Recursividad
/* Factoria -> ! 
1! = 1
2! = 2*1 =2
3! = 3*2*1 = 3
 */

long CalcularFactoria(int n) {
    if (n == 1) {
        return 1; // cuando n = 1 develovemos 1 y terminamos la recursividad
    }
    return n * CalcularFactoria(n-1);
}
