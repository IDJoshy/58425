// Clase #3 CoderHouse C#:  Bucles e iteraciones.

/* Mapa Conceptual
                            
                            ->  Length
                            ->  ToUpper
    - Manejo de cadenas    -->  ToLower
                            ->  ToString
                            ->  Equals/Contains
                            ->  Parse y Convert

    - Bucles --> for y while
 */

/* Manejo de cadenas 
 
    - Concatenar Cadenas (string s = operador1 + operador2 + "Textos";): "+" sirve para concatenar strings.
 
    - Cadenas vacias (empty): una cadena vacia es aquella que contiene 0 caracteres (comportamiento array de char).

        -Para inicializar una cadena vacia se usa la instruccion <String.empty> o el literal <""> (no muy utilizado debido a orden).
        
        - Ej: string s = String.empty; o string s = "";

    - Cadenas nulas: utilizadas para concatenación de otras cadenas y para comparacion en bloques de decición.
        
        - Las cadenas nulas no poseen longitud (Length) a contrario de las cadenas vacias (Length = 0).


    - Length (longitud): propiedad de un array (en este caso una string (cantidad de char)), necesita tener una cantidad si no lanzara error.

    - ToUpper y ToLower: funciones que realizan la accion contraria una de la otra; ToUpper convierte todo caracter de una cadena en mayus, ToLower a minus.

    - ToString: convierte la informacion contenida de una variable a datos string (puede ser utilizada con cualquier variable).

    - Equals / Contains: función String.Equals() permite comparar si una cadena tiene el mismo valor que otra; String.Contains() nos permite saber si una cadena se encuentra dentro de otra.
    
    - Parse: función utilizada para la conversion de cadenas de texto a tipos numericos (se debe validar si la cadena es nula o esta vacia (para que no de error)).
        
        - String.IsNullOrEmpty();
        - Solo pueden poseer caracteres numericos (’-’,’+’,’0’ al ‘9’,’.’).
 */

#region Ejemplos

// Concatenar, cadenas vacias vs cadenas nulas.

string? cadenanula = null;
string cadenaVacia = String.Empty;
string cadenaNoVacia = "Hola soy una cadena no vacia";

Console.WriteLine(String.Empty);
Console.WriteLine("Concatenar");
Console.WriteLine(cadenaNoVacia + cadenanula + cadenaVacia + " Resto de la cadena");

Console.WriteLine(String.Empty);
Console.WriteLine("Comparar");

if (cadenaVacia != cadenanula)
{
    Console.WriteLine("Las cadenas no son iguales");
}
else
{
    Console.WriteLine("Las cadenas son iguales");
}

// Longitudes de cadenas

Console.WriteLine(String.Empty);
Console.WriteLine("Longitud de cadenas");

if (cadenanula == null)
{
    Console.WriteLine("La cadena nula no tiene caracteres");
}
else
{
    Console.WriteLine("La cadena nula tiene: " + cadenanula.Length + " caracteres"); // Generaria un error
}
    
Console.WriteLine("La cadena vacia tiene: " + cadenaVacia.Length + " caracteres");
Console.WriteLine("La cadena no vacia tiene: " + cadenaNoVacia.Length + " caracteres");

// ToUpper y ToLower

Console.WriteLine(String.Empty);
Console.WriteLine("ToUpper y ToLower");
string mensaje = "Voy a trabajar como desarrollador Back-End";
Console.WriteLine("mensaje normal: " + mensaje);
Console.WriteLine("mensaje a mayus: " + mensaje.ToUpper());
Console.WriteLine("mensaje a minus: " + mensaje.ToLower());

// ToString

Console.WriteLine(String.Empty);
Console.WriteLine("ToString");
int numeroEntero = 1234;
double numeroDecimal = 3.1415;
bool boleana = true;

Console.WriteLine("numeroEntero: " + numeroEntero.ToString() + "\nnumeroDecimal: " + numeroDecimal.ToString() + "\nboleana: " + boleana.ToString());

// Equals y Contains

string cadena0 = "Soy una cadena    ";
string cadena1 = "Soy una cadena";

Console.WriteLine(String.Empty);
Console.WriteLine("Equals");
if (!cadena0.Equals(cadena1))
{
    Console.WriteLine("cadena0 no es igual a cadena1");
}
else
{
    Console.WriteLine("cadena0 es igual a cadena1");
}

Console.WriteLine(String.Empty);
Console.WriteLine("Contains");
if (!cadena0.Contains(cadena1))
{
    Console.WriteLine("cadena0 no contiene a cadena1");
}
else
{
    Console.WriteLine("cadena0 contiene a cadena1");
}

// Parse

Console.WriteLine(String.Empty);
Console.WriteLine("Parse");
Console.WriteLine("Ingrese numero");
string? cadena2 = Console.ReadLine();

const double constante = 0.5;
double cadenaADouble;
double sumaConNumerosDouble;

if (String.IsNullOrEmpty(cadena2)) 
{
    Console.WriteLine("No es posible parsear ya que la cadena es nula o vacia // erronea");
}
else
{
    cadenaADouble = double.Parse(cadena2);
    sumaConNumerosDouble = cadenaADouble + constante;
    Console.WriteLine("El resultado es:  " + sumaConNumerosDouble.ToString());
}
#endregion
