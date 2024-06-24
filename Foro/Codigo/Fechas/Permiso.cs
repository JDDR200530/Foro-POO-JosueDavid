using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foro.Codigo.Fechas
{
    public abstract class Permiso
    {
        public string Fechas { get; set; }
        public abstract void Verificar();
    }

    public class FechadeEmision : Permiso
    {
        public override void Verificar()
        {
            Console.WriteLine($"\nFecha de Emision del Permiso: {Fechas}");
        }
    }

    public class FechadeVencimiento : Permiso
    {
        public override void Verificar()
        {
            Console.WriteLine($"\nFecha de Vencimiento del Permiso : {Fechas}");
        }
    }
}
