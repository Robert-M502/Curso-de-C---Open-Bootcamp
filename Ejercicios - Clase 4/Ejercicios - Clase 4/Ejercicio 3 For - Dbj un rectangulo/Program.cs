
int ancho;
int alto; 
int numFiguras;
bool relleno;

Console.Write("Introduce el ancho: ");
ancho = Convert.ToInt32(Console.ReadLine());

Console.Write("Introduce el alto: ");
alto = Convert.ToInt32(Console.ReadLine());

Console.Write("Introduce 1 si quieres relleno, 0 si no: ");
relleno = Convert.ToInt32(Console.ReadLine()) == 1;

Console.Write("Introduce el número de figuras a dibujar: ");
numFiguras = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < numFiguras; i++)
{
    if (ancho == alto)
    {
        DibujarCuadrado(ancho, relleno);
    }
    else
    {
        DibujarRectangulo(ancho, alto, relleno);
    }
}

static void DibujarCuadrado(int lado, bool relleno)
{
    for (int i = 0; i < lado; i++)
    {
        for (int j = 0; j < lado; j++)
        {
            if (relleno || i == 0 || i == lado - 1 || j == 0 || j == lado - 1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

static void DibujarRectangulo(int ancho, int alto, bool relleno)
{
    for (int i = 0; i < alto; i++)
    {
        for (int j = 0; j < ancho; j++)
        {
            if (relleno || i == 0 || i == alto - 1 || j == 0 || j == ancho - 1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

