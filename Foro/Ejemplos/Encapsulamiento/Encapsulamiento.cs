public class Persona
{
    // Campos privados encapsulados
    private string? nombre;
    private int edad;

    // Propiedades públicas para acceder a los campos encapsulados
    public string Nombre
    {
        get { return nombre; }
        set
        {
            // Validación opcional
            if (!string.IsNullOrEmpty(value))
                nombre = value;
        }
    }

    public int Edad
    {
        get { return edad; }
        set
        {
            // Validación opcional
            if (value > 0 && value < 120) // Suponiendo una edad razonable
                edad = value;
        }
    }

    // Método para mostrar información
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}\n");
    }
}