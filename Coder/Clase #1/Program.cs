// Clase #1 CoderHouse C#

/* Variables y Constantes 
 
  - Variables: es un pequeño espacio de memoria de computadora donde se guardan datos que se autilizaran a 
    largo plazo en la vida del programa.

    Una representacion de lo que es una variable se relacionaria a una caja 

      ________
     /   1   /|  - Cierto tamaño
    /       / |  - Con una etiqueta ("numeros")
    |-------| |  - Dentro de ella se puede guardar un dato ("1")
    |numeros| |
    |_______|/  -> int (numeros entreros)

    las variables se identifican con un nombre que puede variar pero no se puede repetir
    Se deben cumplir ciertas reglas para poder nombrar a la variable:
    -Pueden contener Numeros y letras.
    -No se admiten la mayoria de simbolos (a excepción del guion bajo).
    -No puden comenzar por un numero, no pueden tener espacios ni caracteres especiales.
        
        -Ejemplo: nombre_Apellido3, i, contadorSuma

  - Constantes: representan datos fijos dentro de un programa, que al igual que las variabales son utilizadas
    a lo largo de la vida del programa. una vez inicializadas no pueden cambiar el valor.

 */

/* Datos
 
  - Tipos de datos:

    - int, long, short  | Numeros enteros | 178; -52; 6276372623
    - float, double     | decimales       | 3.5f; 3,1412; - 67,4336726782; 3 
    - bool              |Verdadero o falso| true; false
    - string            | texto           | “coderhouse”
    - char              | caracteres      | ‘1’; ’@’ ; ‘A’

  - Declaracion de una variable 
    
    int numero_Entero; >cada varible se debe terminar con punto y coma (;).
    
  - Declaracion de una constante
    
    const double pi = 3.14159; > para decimales se usa punto en vez de coma.
    
 */

#region Ejemplos

/*
     * guardar los siguientes datos en variables y mostrarlos por consola:
     
        Nombre: 
        Apellido: 
        DNI:
        Edad:
        Altura:
*/

string nombre;
string apellido;
const int dni = 213695177;
int edad;
float altura;

Console.WriteLine("Ingrese su Nombre");
nombre = Console.ReadLine();
Console.WriteLine("Ingrese su Apellido");
apellido = Console.ReadLine();
Console.WriteLine("Ingrese su Edad");
edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese su Altura");
altura = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Bienvenido: {0} {1}, {2}", nombre, apellido, dni);
Console.WriteLine("Altura: {0}", altura);

/*
     * Sumar dos números
*/

int primerNumero;
int segundoNumero;

Console.WriteLine("Ingrese primer numero");
primerNumero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese segundo numero");
segundoNumero = Convert.ToInt32(Console.ReadLine());

int suma = (primerNumero + segundoNumero);

Console.WriteLine(suma);

/*
     * Concatenar 
*/

Console.WriteLine("Ingrese primera palabra");
string primeraPalabra = Console.ReadLine();
Console.WriteLine("Ingrese segunda palabra");
string segundaPalabra = Console.ReadLine();

string palabraFinal = primeraPalabra + " \"Coder\" " + segundaPalabra;

Console.WriteLine(palabraFinal);

#endregion