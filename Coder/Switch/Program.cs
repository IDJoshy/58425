using System.ComponentModel.DataAnnotations;

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
    else if(nota > 7 && nota <= 10 )
    {
        Console.WriteLine("Promocion");
    }
}
