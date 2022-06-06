
using EjercicioCafetera2;

Cafetera cafetera = new Cafetera();

cafetera.Encender();
cafetera.MostrarContenido();

int opcion = 0;

do
{
    Console.WriteLine("Para cafe fuerte ingrese 1");
    Console.WriteLine("Para cafe suave ingrese 2");
    Console.WriteLine("Para cafe con leche ingrese 3");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Para rellenar agua ingrese 4");
    Console.WriteLine("Para rellenar cafe ingrese 5");
    Console.WriteLine("Para rellenar leche ingrese 6");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Para salir ingrese 0");

    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
        cafetera.PrepararFuerte();
    }
    else if (opcion == 2)
    {
        cafetera.PrepararSuave();
    }
    else if (opcion == 3)
    {
        cafetera.PrepararConLeche();
        cafetera.PrepararConLeche();
        cafetera.PrepararConLeche();
    }
    else if (opcion == 4)
    {
        cafetera.RellenarAgua();
    }
    else if (opcion == 5)
    {
        cafetera.RellenarCafe();
    }
    else if (opcion == 6)
    {
        cafetera.RellenarLeche();
    }
} while (opcion != 0);
