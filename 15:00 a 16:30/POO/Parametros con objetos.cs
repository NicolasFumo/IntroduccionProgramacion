// cargar 3 examenes y mostrar el nombre
// del estudiante con la calificacion
// mas alta

Examen examen1 = new Examen();
Examen examen2 = new Examen();
Examen examen3 = new Examen();

examen1.CargarExamen(1);
examen2.CargarExamen(2);
examen3.CargarExamen(3);

if(examen1.CompararExamen(examen2))
{
    if(examen1.CompararExamen(examen3))
    {
        Console.WriteLine($"El examen {examen1.NombreAlumno} es el mayor");
    }
    else
    {
        Console.WriteLine($"El examen {examen3.NombreAlumno} es el mayor");
    }
}
else
{
    if (examen2.Nota > examen3.Nota)
    {
        Console.WriteLine($"El examen {examen2.NombreAlumno} es el mayor");
    }
    else
    {
        Console.WriteLine($"El examen {examen3.NombreAlumno} es el mayor");
    }
}

class Examen
{
    public string NombreAlumno;
    public int Nota;

    public void CargarExamen(int numeroExamen)
    {
        Console.Write($"ingrese nombre del alumno {numeroExamen}: ");
        NombreAlumno = Console.ReadLine();

        Console.Write($"Ingrese nota alumno {numeroExamen}: ");
        Nota = int.Parse(Console.ReadLine());
    }
    // booleano
    public bool CompararExamen(Examen examen)
    {
        if(Nota > examen.Nota)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
