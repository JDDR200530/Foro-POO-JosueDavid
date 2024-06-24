using Foro.Codigo.Fechas;
using Foro.Codigo.Motor;
using Foro.Codigo.Propietario;
using Foro.Ejemplos.Abstracion;
using Foro.Ejemplos.Herencia;
using Foro.Ejemplos.Poliformismo;
using System.Diagnostics.Tracing;
using static Foro.Ejemplos.Poliformismo.Poliformismo;

namespace Foro
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Herencia 
            //Leon oLeon = new Leon();
            //oLeon.Nombre = "Leon";
            //oLeon.CantidadCarneCome = 10;
            //oLeon.ColordePiel = "Amarillo";

            //Aguila oAguila = new Aguila();
            //oAguila.Nombre = "Aguila Arpia";
            //oAguila.CantidadCarneCome = 2;
            //oAguila.ColorPlumas = "Cafes";
            //Console.WriteLine($"Nombre: {oLeon.Nombre}, Cantidad de Carne que come: {oLeon.CantidadCarneCome}kg, Color de piel: {oLeon.ColordePiel}\n");
            //Console.WriteLine($"Nombre: {oAguila.Nombre}, Cantidad de Carne que come: {oAguila.CantidadCarneCome}kg, Color de plumas: {oAguila.ColorPlumas}\n");

            ////Encapsulamiento 
            //Persona persona1 = new Persona();
            //persona1.Nombre = "Carlos";
            //persona1.Edad = 24;
            //persona1.MostrarInformacion();

            ////Abstraccion 

            //Coche miCoche = new Coche("Toyota", "Corolla", 2023);

            //// Utilizando la abstracción a través de la interfaz IVehiculo
            //IVehiculo vehiculo = miCoche;
            //vehiculo.Arrancar();
            //vehiculo.Detener();

            //// Accediendo a los detalles del vehículo a través del método abstracto de la clase base
            //miCoche.MostrarDetalles();

            ////Poliformismo 
            //Domestico miPerro = new Perro { Name = "Fido" };
            //Domestico miGato = new Gato { Name = "Michi" };
            //miPerro.HacerSonido();
            //miGato.HacerSonido();



            // Codigo por Josue David Diaz 
            Console.WriteLine("Codigo del Alumno\n");
            Modelos oModelos = new Modelos();
            oModelos.Marca = "Toyota";
            oModelos.Modelo = "22R";
            oModelos.Año = 1997;
            oModelos.Color = "Rojo Vino";
            Console.WriteLine($"Marca : {oModelos.Marca}\nModelo : {oModelos.Modelo}\nAño : {oModelos.Año}\nColor : {oModelos.Color}\n ");

            Propietario propietario = new Propietario();
            propietario.NombrePropietario = "Juan Perez";
            propietario.IdentificacionPropietario = "1305-1987-00001";
            propietario.PlacadeVehiculo = "HCR2004";
            propietario.Datos();

            Carro miCarro = new Carro("Gasolina", 4, "13411-38010");
            miCarro.Detalles();

            Permiso miFechadeEmision = new FechadeEmision { Fechas = "23/06/2024" };
            Permiso miFechadeVencimiento = new FechadeVencimiento { Fechas = "23/06/2025" };
            miFechadeEmision.Verificar();
            miFechadeVencimiento.Verificar();



        }
    }
}
        