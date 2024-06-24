using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Foro.Codigo.Propietario
{
    internal class Propietario : Automotor
    {
        private string? Nombre;
        private string? Identificacion;
        private string? Placa;

        public string NombrePropietario
        {
            get { return Nombre; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    Nombre = value;
            }
        }

        public string IdentificacionPropietario
        {
            get { return Identificacion; }
            set
            {
                // Validar que la identificación tenga exactamente 13 dígitos numéricos
                if (value != null && System.Text.RegularExpressions.Regex.IsMatch(value, @"^[\d+-]{13,15}$"))
                {
                    Identificacion = value;
                }
                else
                {
                    //throw new ArgumentException("La identificación debe tener exactamente 13 dígitos numéricos.");
                }
            }
        }

        public string PlacadeVehiculo
        {
            get { return Placa; }
            set
            {
                // Validar que la placa tenga exactamente 7 caracteres
                if (value != null && ValidarPlaca(value))
                {
                    Placa = value;
                }
                else
                {
                    throw new ArgumentException("La Placa debe tener exactamente 7 caracteres: los primeros 3 letras y los últimos 4 números.");
                }
            }
        }

        private bool ValidarPlaca(string placa)
        {
            // Validar que la placa tenga exactamente 7 caracteres
            if (placa.Length != 7)
                return false;

            // Validar que los primeros 3 caracteres sean letras
            for (int i = 0; i < 3; i++)
            {
                if (!char.IsLetter(placa[i]))
                    return false;
            }

            // Validar que los últimos 4 caracteres sean números
            for (int i = 3; i < 7; i++)
            {
                if (!char.IsDigit(placa[i]))
                    return false;
            }

            return true;
        }  
        public void Datos()
    {
        Console.WriteLine($"Propietario: {Nombre},\nIdentificacion del Propietario: {Identificacion}\nPlaca del Vehiculo: {Placa}");
    }
    }
 
}