using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foro.Ejemplos.Herencia
{
    internal class Aguila: Carnivoro
    {
        public string? ColorPlumas { get; set; }
        public void Informacion2()
        {
            Console.WriteLine($"Nombre : {Nombre}, Cantidad de Carne que come: {CantidadCarneCome}kg, Color de piel : {ColorPlumas} ");
        }
    }
}
