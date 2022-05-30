
Alumno pepe = new Alumno();
Docente carlos = new Docente();

carlos.Saludar();

pepe.Saludar();


class Persona
{
    public string Nombre;
    public string Apellido;

    public void Saludar()
    {
        Console.WriteLine($"Me llamo: {Nombre}");
    }
}

class Docente : Persona
{
    public string Asignatura;
    public string Horarios;
}

class Alumno : Persona
{
    public string Curso;
    public int Nota;
}

class Preceptor : Persona 
{
    public string Turno;
    public string Horario;
}
