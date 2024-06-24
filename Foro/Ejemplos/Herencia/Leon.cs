using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foro.Ejemplos.Herencia
{
    public class Leon : Carnivoro
    {
        public string? ColordePiel{  get; set; }
        public void Informacion1()
        {
            Console.WriteLine($"Nombre : {Nombre}, Cantidad de Carne que come: {CantidadCarneCome}kg, Color de piel : {ColordePiel} ");
        }
    }
}
