using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections;

ListarCoches();

Console.WriteLine("\nColección personalizada");

var colors = new MisColores();
foreach (Colores theColor in colors) {
    Console.WriteLine($"Color: {theColor.Nombre}, Hex: {theColor.CodigoHex}, Opacidad: {theColor.opacidad}");
}

// End main

static void ListarCoches() {
    var cars = new List<Car> {
        {new Car(){Name = "Car4", Color = "grean", Speed = 40 }},
        {new Car(){Name = "Car5", Color = "violet", Speed = 20 }},
        {new Car(){Name = "Car5", Color = "red", Speed = 40 }},
        {new Car(){Name = "Car5", Color = "red", Speed = 60 }},
        {new Car(){Name = "Car1", Color = "blue", Speed = 20 }},
        {new Car(){Name = "Car2", Color = "red", Speed = 50 }},
        {new Car(){Name = "Car3", Color = "yellow", Speed = 30 }}
    };
    cars.Sort();
    foreach (Car coche in cars) {
        Console.WriteLine($"{coche.Name}, {coche.Color}, {coche.Speed}");
    }
}
class Car : IComparable<Car> {
    public string Name { get; set; }
    public string Color { get; set; }
    public int Speed { get; set; }
    public int CompareTo(Car other) {
        int compare;
        compare = String.Compare(this.Name, other.Name, true);
        if (compare == 0) {
            compare = this.Speed.CompareTo(other.Speed);  
            compare = -compare;
        }
        return compare;
    }  
}

// Coleccion personalizada
public class MisColores : System.Collections.IEnumerable {
    private Colores[] _colores = {
        new Colores() { Nombre = "Rojo", CodigoHex = "CB3234", opacidad = 0.55f},
        new Colores() { Nombre = "Azul", CodigoHex = "000FF"},
        new Colores() { Nombre = "Verde", CodigoHex = "009F39"},
        new Colores() { Nombre = "Amarillo", CodigoHex = "CB3234"},
    };
    public System.Collections.IEnumerator GetEnumerator () {
        return new ColoresEnumerator(_colores);
    }
    private class ColoresEnumerator : System.Collections.IEnumerator {
        private Colores[] _colors;
        private int _position = -1;

        public ColoresEnumerator(Colores[] colors)
        {
            _colors = colors;
        }
        object System.Collections.IEnumerator.Current {
            get {
                return _colors[_position];
            }
        }

        bool System.Collections.IEnumerator.MoveNext ()
        {
            _position++;
            return (_position < _colors.Length);
        }
        void System.Collections.IEnumerator.Reset ()
        {
            _position = -1;
        }
    }
}

public class Colores { 
    public string Nombre { get; set; }
    public string CodigoHex { get; set;  }

    public float opacidad { get; set; }
}