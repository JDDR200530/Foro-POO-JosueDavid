using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Foro.Codigo.Motor
{
    public abstract class Motor
    {
        public string TipodeMotor { get; set; }
        public int CantidaddeCilindros { get; set; }
        public string CodigodelMotor { get; set; }

        public abstract void Detalles();
    }

    public class Carro : Motor
    {
        public Carro(string tipodemotor, int cantidaddecilindros, string codigodelmotor)
        {
            TipodeMotor = tipodemotor;
            CantidaddeCilindros = cantidaddecilindros;
            CodigodelMotor = codigodelmotor;
        }

        public override void Detalles()
        {
            Console.WriteLine($"Tipo de motor: {TipodeMotor}, Cantidad de cilindros: {CantidaddeCilindros}, Código del motor: {CodigodelMotor}");
        }
    }
}
