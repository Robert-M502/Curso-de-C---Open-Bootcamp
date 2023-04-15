
/* Strings */
using System.IO.Pipes;

string str;
string str2 = null;
string str3 = System.String.Empty;
string str4 = "";
string str5 = " ";


// Areglos de char y strings
char[] letras = { '#', '$', '%' };
Console.WriteLine(letras[0]);

string str6 = "#$%";
Console.WriteLine(str6[1]);

// Concatenación
string ms1 = "Hola";
string ms2 = "estoy programando en c#";
Console.WriteLine(ms1 + ", " + ms2);
string ms3 = ms1 + ms2;
string ms4 = ms1;
ms4 += ms2;
Console.WriteLine(ms4);

// Literales
// Caracteres escapados -> \n \u00C6 Æ \r \t
string columns = "Columna 1\tColumna 2\tColumna 3";
string hr = "____________________________________________";
string content = "Contenido 1\tContenido 2\tContenido 3";
Console.WriteLine(columns);
Console.WriteLine(hr);
Console.WriteLine(content);

// Algunos caracteres escapados: \' \" \\ \v etc...
string multilinea = "Hola, " +
    "Esto es un mensaje" + 
    " en varias lineas";
string multilinea2 = @"Este es 
                        un mensaje de verias lineas
                        sin concatenar";

string comillas = @"I'm Robert ""programador""";
Console.WriteLine(comillas);

//Interpolación
var persona = (nombre: "Robert", nacimiento: 1999, edad: "32", lenguaje: "C#");
Console.WriteLine($"{persona.nombre} es un hombre de {2023 - persona.nacimiento} años y le gusta programar en {persona.lenguaje}");

// Subcadenas
string miCadena = " Este es un mensaje";
// substring, replace, indexOf, trim
string miCadena2 = miCadena.Substring(0, 10);
Console.WriteLine(miCadena2);
string miCadena3 = miCadena.Replace("mensaje", "podcast");
Console.WriteLine(miCadena3);
string miCadena4 = miCadena.Trim();
Console.WriteLine(miCadena4);
// Encontrar caracter
int index = miCadena.IndexOf('m');
Console.WriteLine(index);

// Strings nulos y vacíos
string str7 = "Hola";
string nullStr = null;
string emptyStr = String.Empty;

string tempStr = str7 + nullStr;
Console.WriteLine(tempStr);

bool b = (emptyStr == nullStr); // Came case 
Console.WriteLine(b);

string newStr = emptyStr + nullStr;
Console.WriteLine(newStr);
Console.WriteLine(emptyStr.Length);
Console.WriteLine(newStr.Length);

// Añadimos valores
nullStr = "a";
Console.WriteLine(nullStr.Length);

emptyStr = "";
emptyStr += nullStr;
Console.WriteLine(emptyStr);

// StringBuilder
StringBuilder strBuilder = new StringBuilder("Hola, Mundo");
Console.WriteLine(strBuilder[0]); // H
Console.WriteLine(strBuilder); // Hola, mundo

// Transformar una cadena a número si es posible
float i = 0;
string s = "12345.1234";
bool result = float.TryParse(s, out i);
Console.WriteLine(result + ", i: " + i);

