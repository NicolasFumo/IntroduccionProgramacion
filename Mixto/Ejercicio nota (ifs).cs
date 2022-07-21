/* es mayor que 8 -> promocionado
 * 8 - 6 -> regular
 * es menor que 6 -> reprobado
 */

int nota;

Console.WriteLine("Ingrese la calificacion");
nota = int.Parse(Console.ReadLine());

if(nota > 8)
{
    Console.WriteLine("Promocionado");
}
else
{
    if(nota >= 6)
    {
        Console.WriteLine("Regular");
    }
    else
    {
        Console.WriteLine("Reprobado");
    }
}
