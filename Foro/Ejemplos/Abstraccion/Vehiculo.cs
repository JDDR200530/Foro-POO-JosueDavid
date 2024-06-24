using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foro.Ejemplos.Abstracion
{
    using System;

    // Interfaz para definir el comportamiento de un vehículo
    public interface IVehiculo
    {
        void Arrancar();
        void Detener();
    }

    // Clase abstracta que define propiedades comunes de un vehículo
    public abstract class VehiculoBase
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int Año { get; set; }

        public abstract void MostrarDetalles();
    }

    // Clase concreta que hereda de VehiculoBase e implementa IVehiculo
    public class Coche : VehiculoBase, IVehiculo
    {
        public Coche(string marca, string modelo, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Año}","\n");
        }

        public void Arrancar()
        {
            Console.WriteLine("El coche ha arrancado.");
        }

        public void Detener()
        {
            Console.WriteLine("El coche se ha detenido.");
        }
    }

    
}

