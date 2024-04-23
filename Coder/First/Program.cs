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
    if(stock <= 5) 
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