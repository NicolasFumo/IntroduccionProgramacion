
Persona carlos = new Persona("Carlos", "Zario");
Persona alumno = new Persona();

carlos.Saludar();

class Persona
{
    public Persona(string nombre, string apellido)
    {
        Nombre = nombre;
        Apellido = apellido;
    }

    public Persona()
    {

    }

    public string Nombre;
    public string Apellido;

    public void Saludar()
    {
        Console.WriteLine($"Me llamo: {Nombre}");
    }

    public void Saludar(string mensaje)
    {
        Console.WriteLine($"{mensaje}: {Nombre}");
    }
}
