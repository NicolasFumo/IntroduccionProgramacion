using EjericioCafetera;

Cafetera cafeteraBar = new Cafetera();

cafeteraBar.Encender();

cafeteraBar.MostrarContenedores();

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
        cafeteraBar.PrepararFuerte();
    }
    else if (opcion == 2)
    {
        cafeteraBar.PrepararSuave();
    }
    else if (opcion == 3)
    {
        cafeteraBar.PrepararConLeche();
    }
    else if (opcion == 4)
    {
        cafeteraBar.RellenarAgua();
    }
    else if (opcion == 5)
    {
        cafeteraBar.RellenarCafe();
    }
    else if (opcion == 6)
    {
        cafeteraBar.RellenarLeche();
    }
    else if (opcion == 0)
    {

    }
} while (opcion != 0);






