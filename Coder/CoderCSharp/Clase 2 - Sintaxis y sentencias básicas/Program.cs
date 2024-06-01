/* Numeros enteros
    - short | 2 bytes | [-32768 a 32767]
    - int   | 4 bytes | [-2147483648 a 2147483647]
    - long  | 8 bytes | [-9223372036854775808 a 9223372036854775807]
*/

/* Números Reales
    - float | 4 bytes | [De 6 a 9 dígitos aproximadamente]
    - double| 8 bytes | [De 15 a 17 dígitos aproximadamente]
*/

/* Operadores Aritméticos
 
    Símbolo | Descripción del símbolo   | Tipo
        *   | Multiplicación            | binario
        /   | División                  | binario
        %   | Resto de division         | binario
        ++  | Incremento de 1           | unario
        --  | Decremento de 1           | unario
        +   | Suma o signo positivo     | ambos
        -   | Resta o signbo negativo   | ambos
*/

/* Textos en C#

    - Caracteres (char): Representan los simbolos de cada letra mediante codificación digital.
    - Cadenas (string): Cadena secuencial de caracteres, con posicion, puede ser nula o vacia (deben validar valores).  
*/

/* Variables booleanas 
    
    - Variables de decisión o booleanas (bool): representan un valor de true or false (1,0);
*/

/* Literales
    
    - Son los valores que se utilizan en una variable, dependiendo su tipo de dato.

    y = a + b * 2 * 0.5f;

        y, a, b son variables ya que pueden cambiar de valor.
        2 y 0.5f son literales ya que no pueden cambiar el valor establecido.

        Tipo de dato        | Descripción               | Ejemplo Literales
        int, long , short   | Números enteros           |  
        float               | flotante                  | float numFloat = 3.5f; // notar la f al final
        double              | Flotante mayor precisión  | double numDoble = 2.3423422442; // notar el punto en vez de la coma
        bool                | verdadero o falso         | bool check=false; //solo pueden ser true o false
        string              | texto                     | Console.Writeline(“Soy una cadena literal”); // notar que se escriben entre comillas dobles
        char                | caracteres                | char caracterLiteral= ‘@’; // notar que se escribe entre comillas simples

*/

/* Condicionales
   
    - Cuando nos encontramos en una situación en la cual se debe tomar una decisión, 
      debemos optar por un camino de los 2 o más que pueden llegar a cruzarse.

    - if/ if-else: Se compone de tres partes diferenciadas (bloque de condiciones o preguntas, 
      bloque verdadero, bloque falso o "else" (opcional)).

    	if (condición) // Solo verdadero (Simples)
          {
		    sentencias...
          }

	    if (condición) // Cuando tenemos dos opciones posibles Sintaxis (Compuestas)

          {
		    sentencias...
          }
          else
          {
		    sentencias...
          }

	    if (condición) // Cuando tenemos más de dos opciones posibles (Anidados)
          {
		    if (condición)
              {
		        sentencias
              }
          }
          else
          {
		    if (condición)
              {
		        sentencias
              }
          }
    
        - Operadores para condiciones:

         OPERADOR   | DESCRIPCIÓN       | EJEMPLO
            = =     | igual a           | if(stock == 23)
            ! =     | distinto a        | if(stock != 5)
            >       | mayor a           | if(stock > 50)
            <       | menor a           | if(stock< 50)
            >=      | mayor o igual a   | if(precio >= 8)
            <=      | menor o igual a   | if(precio <= 55)

        - Operadores Lógicos:

         OPERADOR   | DESCRIPCIÓN       | EJEMPLO           | Devuelve cuando
            &&      | y                 | if (7>2 && 4<5)   | Ambas son verdaderas
            ||      | 0                 | if (7<2 || 4<5)   | Alguna es verdadera
            !       | no o distinto a   | if(!4 > 50)       | Niega el valor de la expresión. O sea, si la condición es false, el resultado es true.

    -switch/case-default: se compone de tres partes bien diferenciadas (Bloque de expresion, Bloque case, Bloque default(opcional)).

        switch (nombreVariable)
        {	
            case valor1:
		            sentencias
		            break;
            case valor1:
		            sentencias
		            break;
            case valor1:
		            sentencias
		            break;
            …
            default:
		            sentencias
                    break;
        }

*/

#region Ejemplo if / if-else y switch

// if-else
int cantidadProductoVendido;
int cantidadProductoDeposito = 50;
int stock;

Console.WriteLine("Ingresar cantidad de producto a vender");
cantidadProductoVendido = Convert.ToInt32(Console.ReadLine());

stock = cantidadProductoDeposito - cantidadProductoVendido;

if (stock == 0)
{
    Console.WriteLine("Reponer stock");
    cantidadProductoDeposito += 10;
    Console.WriteLine("Productos Renovados");
}
else
{
    if (stock <= 5)
    {

        Console.WriteLine("Stock minimo, reponer");
        cantidadProductoDeposito += 5;
        Console.WriteLine("Producto cargado a deposito");
        Console.WriteLine("Informar {0} productos sin vender", stock);
    }
    else
    {
        Console.WriteLine("Informar {0} productos sin vender", stock);
    }


}

//Switch
string commision;

Console.WriteLine("Ingrese turno A, B, C");

commision = Console.ReadLine();

switch (commision)
{
    case "A":
    case "a":
        Console.WriteLine("Turno Mañana");
        break;

    case "B":
    case "b":
        Console.WriteLine("Turno Tarde");
        break;

    case "C":
    case "c ":
        Console.WriteLine("Turno noche");
        break;

    default:
        Console.WriteLine("Turno fijado");
        break;
}

// if, else, else if

float nota;

Console.WriteLine("Ingrese nota");
nota = Convert.ToSingle(Console.ReadLine());

if (nota < 0 || nota > 10)
{
    Console.WriteLine("Nota invalida");
}
else
{
    if (nota >= 0 && nota < 4)
    {
        Console.WriteLine("Reprobado");
    }
    else if (nota >= 4 && nota <= 7)
    {
        Console.WriteLine("Aprobado");
    }
    else if (nota > 7 && nota <= 10)
    {
        Console.WriteLine("Promocion");
    }
}

#endregion