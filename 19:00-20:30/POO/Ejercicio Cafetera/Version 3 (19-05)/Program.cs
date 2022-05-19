using Cafetera19hs;

Cafetera Agenpia = new Cafetera();

Agenpia.Encender();
Agenpia.MostrarContenedores();

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
    Console.WriteLine("Para salir ingrese 0");

    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
        Agenpia.PrepararFuerte();
    }
    else if (opcion == 2)
    {
        Agenpia.PrepararSuave();
    }
    else if (opcion == 3)
    {
        Agenpia.PrepararConLeche();
    }
    else if (opcion == 4)
    {
        Agenpia.RellenarAgua();
    }
    else if (opcion == 5)
    {
        Agenpia.RellenarCafe();
    }
    else if (opcion == 6)
    {
        Agenpia.RellenarLeche();
    }
} while (opcion > 0);

