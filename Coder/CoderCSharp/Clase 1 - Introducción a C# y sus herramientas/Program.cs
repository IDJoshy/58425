// C# Clase 01 CoderHouse Introducción y Herramientas


/* Un poco de Historia

Desarrollado por Microsoft en el año 1999 (Andrés Hejlsberg y su equipo), el objetivo era permitir la creación de programas 
en .NET Framework (Primera version 2002)

En un principio se llamaba Cool (C Oriented Object Language)
 */

/* .NET 
 
.NET Framework

Es un conjunto de lenguajes, estándares y herramientas integradas para facilitar el desarrollo de aplicaciones de variada extención.

En el año 2002, Microsoft lanza la primera version de .NET Framework para competir con el desarrollo de paginas web y otros lenguajes
como Java y/o PHP

Como producto surge la primera versión de Visual Studio .NET.


.NET Core

Evolución del .NET Framework, con la diferencia distintiva que es multiplataforma y de codigo libre. (2016)

.NET X ya no CORE

NET X es la evolución de .Net Core, su característica distintiva es que es multiplataforma y de código Libre y 
se podrán crear muchos tipos mas de aplicaciones por eso Microsoft decidió no llamarlo “CORE” y 
tambien distinguirlo de FRAMEWORK”.. (NET 5 en 2020)

 */


/* Presente de C#
 
Hoy en dia C# es uno de los lenguajes mas utilizados al rededor del mundo, gracias a su eficacia y modernidad.
 
 */

/* Caracteristicas
 
 C# Es un lenguaje de alto nivel, fuertemente tipado y orientado a objetos.

Alto Nivel: Referencia a la hora de escibir codigo es mas cercano al lenguaje humano, permitiendo la abstracción a la hora de 
escribir codigo (Requiere un Compilador).

Fuertemente Tipado: No permite violaciones entre sus tipos de datos.

Orientado a Objetos: Un objeto es la representacion de algo tangible o abstracto, esto permite modelar de forma eficiente una situación
del mundo real.
 
 */


/* Algoritmos
 
 Un algoritmo es un conjunto ordenado de intrucciones que permite resolver un problema planteado.

 Podemos decir que programar es la actividad de comunicar a la computadora una serie de Algoritmos que permiten
 resolver un problema planteado.

Todo lenguaje de programación posee:
Un léxico: palabras claves(o símbolos) que utilizamos para escribir un programa.
Una sintaxis: son las reglas que indican de qué forma se combinan los símbolos para lograr escribir líneas de código válidas.
Una semántica: cada instrucción válida del lenguaje de programación tiene un propósito particular. Indica algo que se quiere que la computadora haga.

 */

/* Variables
 
 Una variable es un pequeño espacio de memoria de computadora donde se guardan datos que se autilizaran a 
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

// Ejemplos

// Mostrar variables: Guardar Valores en Consola (Nombre: Apellido: DNI: Edad: Altura:)

using System.Net;

string? nombre = String.Empty;
string? apellido = String.Empty;
double dni = 213695177;
int edad = 20;
float altura = 1.70f;


Console.WriteLine("Ejemplo N°1: Guargar Valores Consola");

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

// Sumar dos números

int primerNumero;
int segundoNumero;

Console.WriteLine("Ingrese primer numero");
primerNumero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese segundo numero");
segundoNumero = Convert.ToInt32(Console.ReadLine());

int suma = (primerNumero + segundoNumero);

Console.WriteLine(suma);

// Concatenar

Console.WriteLine("Ingrese primera palabra");
string primeraPalabra = Console.ReadLine();
Console.WriteLine("Ingrese segunda palabra");
string segundaPalabra = Console.ReadLine();

string palabraFinal = primeraPalabra + " \"Coder\" " + segundaPalabra;

Console.WriteLine(palabraFinal);
