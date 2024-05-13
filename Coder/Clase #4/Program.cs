// Clase #4 Coder House C#: Funciones

/* 
 
    - Funciones: 



    - Estructura: las funciones se componen de:
        
        - Modificador: caracteristica especial de la función.
        - Tipo de dato: refiere al tipo de dato que retorna la funcion
 
 
 */

/*    
Console.WriteLine("Ingrese Numero 1");

 int numeroASumar1 = int.Parse(Console.ReadLine());

Console.WriteLine(String.Empty);

Console.WriteLine("Ingrese Numero 2");

int numeroAsumar2 = int.Parse(Console.ReadLine());

 int suma = Suma(numeroASumar1, numeroAsumar2);

Console.WriteLine($"La suma es {suma}");

int Suma(int a, int b)
{
    return (a + b);
}

string Ocultar(string textoParaOcultar) 
{
    string contraOcultada = String.Empty;
    foreach (char c in textoParaOcultar)
    {
        contraOcultada += '*';
    }
    return contraOcultada;
}

string contrasenia = Console.ReadLine();

string oculta = Ocultar(contrasenia);
Console.WriteLine($"la contraseña oculta es: {oculta}");

*/


// Realizar Venta con login 
// Joshua Auristondo 

#region User Validation

int intentos = 0; // Guarda la cantida de intentos (Ingreso Contraseña)

string userNameTemp = String.Empty; // Input del nombre del usuario
string userPasswordTemp = String.Empty; // Input de la contraseña del usuario

const string userName = "User_2024_Coder"; // Nombre que el usuario debe ingresar.
const string userPassword = "password123"; // Contraseña que el usuario debe ingresar.

IniciarPrograma(true); // Iniciar Programa por primera vez.

void IniciarPrograma(bool primeraVez)
{
    Console.WriteLine(primeraVez ? "Bienvenido a la tienda de artículos de limpieza.\n- Por favor ingrese usuario:" : "\n- Por favor ingrese usuario:");
    userNameTemp = Console.ReadLine();
    ValidarUsuario(userNameTemp);
}

void ValidarUsuario(string usuario)
{
    if (usuario.Equals(userName))
    {
        Console.WriteLine("\nIngrese contraseña:");
        userPasswordTemp = Console.ReadLine();
        ValidarPassword(userPasswordTemp);
    }
    else
    {
        Console.WriteLine($"Usuario no encontrado / no valido. intente nuevamente");
        IniciarPrograma(false);
    }

}

void ValidarPassword(string password)
{
    intentos++;

    if (password.Equals(userPassword))
    {
        Console.WriteLine("\nContraseña aceptada!");
        SistemaVentas();
    }
    else if (intentos >= 5)
    {
        Console.WriteLine("Contraseña no valida. No quedan intentos restantes \n--Tenga un buen día--");
    }
    else
    {
        int intentosRestantes = 5 - intentos;
        Console.WriteLine($"Contraseña no valida. intente nuevamente, {intentosRestantes} intentos restantes");

        Console.WriteLine("\nIngrese contraseña:");
        userPasswordTemp = Console.ReadLine();
        ValidarPassword(userPasswordTemp);
    }
}

#endregion

#region Sistema de ventas

int cantidad = 0;
int total = 0;

void SistemaVentas()
{
    Console.WriteLine("\nlos productos disponibles son : \n- Desodorante (DES) Precio: 200 \n- Jabón en polvo (JP) Precio: 300 \n- Detergente (DET) Precio: 250");
    Console.WriteLine("Por favor ingrese codigo de producto \nPara salir de la applicacion Ingrese \"FIN\"");
    string codigoSeleccionado = Console.ReadLine();
    ValidarCodigo(codigoSeleccionado);
}
void ValidarCodigo(string codigo) // VALIDA CODIGO INGRESADO
{
    codigo = codigo.ToUpper();

    if (codigo == null)
    {
        Console.WriteLine("Codigo no valido, ingrese nuevamente...");
        string codigoSeleccionado = Console.ReadLine();
        ValidarCodigo(codigoSeleccionado);
    }
    else if (codigo == "DES")
    {
        Console.WriteLine("ingrese cantidad");
        cantidad = Convert.ToInt32(Console.ReadLine());
        ProductoSeleccionado(0, cantidad);
    }
    else if (codigo == "JP")
    {
        Console.WriteLine("ingrese cantidad");
        cantidad = Convert.ToInt32(Console.ReadLine());
        ProductoSeleccionado(1, cantidad);
    }
    else if (codigo == "DET")
    {
        Console.WriteLine("ingrese cantidad");
        cantidad = Convert.ToInt32(Console.ReadLine());
        ProductoSeleccionado(2, cantidad);
    }
    else if (codigo == "FIN")
    {
        Console.WriteLine("Gracias por usar el sistema, tenga un buen día.");
    }
    else
    {
        Console.WriteLine("Codigo no valido, ingrese nuevamente...");
        string codigoSeleccionado = Console.ReadLine();
        ValidarCodigo(codigoSeleccionado);
    }
}
void ProductoSeleccionado(short Index, int cantidad)
{
    switch (Index)
    {
        case 0: // Producto 1 Desodorante
            total = 200 * cantidad;
            FinalizarCompra("Desodorante", cantidad, total);
            break;

        case 1: // Producto 2 Jabón en polvo
            total = 300 * cantidad;
            FinalizarCompra("Jabón en polvo", cantidad, total);
            break;

        case 2: // Producto 3 Detergente
            total = 250 * cantidad;
            FinalizarCompra("Detergente", cantidad, total);
            break;
    }
}
void FinalizarCompra(string producto, int cantidad, int total)
{
    Console.WriteLine($"Desea Completar la compra de {cantidad} de {producto}. \nPrecio total: {total} \nSi/No?");
    string respuesta = Console.ReadLine();
    ValidarRespuesta(respuesta);
}
void ValidarRespuesta(string respuesta)
{
    respuesta = respuesta.ToUpper();
    if (respuesta == "SI")
    {
        Console.WriteLine("Gracias por la compra, tenga un buen día.");
    }
    else if (respuesta == "NO")
    {
        Console.WriteLine("Gracias por usar el sistema, tenga un buen día.");
    }
    else
    {
        Console.WriteLine("Respuesta invalida... Reiniciando sistema.");
        SistemaVentas();
    }
}

#endregion