/* Los datos del mismo se puede agrupar por colecciones
 Evitamos errores y ahorramos tiempo */

Coords misCoordenadas = new Coords(0,1,2);
Console.WriteLine("x: " + misCoordenadas.X);
Console.WriteLine("y: " + misCoordenadas.Y);
Console.WriteLine("z: " + misCoordenadas.Z);

Coords misCoordenadas2 = misCoordenadas with {X = 9};
Console.WriteLine(misCoordenadas2);

//public readonly struct Coords = Solo de lectura
public struct Coords 
    {
        public Coords(double x, double y, double z) {
            X = x;
            Y = y;
            Z = z;
        }

    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public override string ToString() => $"({X}, {Y}, {Z})";
}