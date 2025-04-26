public class Estudiante
{
    string? Nombre;
    int? Edad;
    string? Carrera;
    string? Carnet;
    double? NotaAdmision;
    public void MostrarResumen()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Carrera: {Carrera}");
        Console.WriteLine($"Carnet: {Carnet}");
        Console.WriteLine($"Nota de admisión: {NotaAdmision}");
    }
    public bool PuedeMatricular()
    {
        bool puedeMatricular;
        if(NotaAdmision >= 75)
        {
            puedeMatricular = true;
        }
        else
        {
            puedeMatricular = false;
        }
        return puedeMatricular;
    }
    public static void Main(string[] args)
    {
        Estudiante estudiante = new Estudiante();
        Console.WriteLine("Ingreso de Estudiante");
        Console.WriteLine("Ingrese su nombre: ");
        estudiante.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese su edad: ");
        estudiante.Edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese su carrera: ");
        estudiante.Carrera = Console.ReadLine();
        while(true)
        {
        Console.WriteLine("Ingrese su carnet, el carnet termina en 2025: ");
        estudiante.Carnet = Console.ReadLine();
            if(estudiante.Carnet != null && estudiante.Carnet.EndsWith("2025") )
            {
                Console.WriteLine("Carnet válido.");
                break;
            }
            else if(estudiante.Carnet == null)
            {
                break;
            }
            else
            {
                Console.WriteLine("El carnet no es válido, debe terminar en 2025.");
            }
        }
        Console.WriteLine("Ingrese su nota: ");
        estudiante.NotaAdmision = Convert.ToDouble(Console.ReadLine());       
        estudiante.MostrarResumen();
        estudiante.PuedeMatricular();
        if (estudiante.PuedeMatricular() == true)
        {
            Console.WriteLine("Puede matricularse.");
        }
        else
        {
            Console.WriteLine("No puede matricularse.");
        }
    }
}