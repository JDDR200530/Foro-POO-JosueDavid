using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foro.Ejemplos.Poliformismo
{
    internal class Poliformismo
    {
        public abstract class Domestico
        {
            public string? Name { get; set; }
            public abstract void HacerSonido();
        }
        public class Perro : Domestico
        {
            public override void HacerSonido()
            {
                Console.WriteLine($"\n{Name} dice: !Guau!");
            }
            
            }
        public class Gato : Domestico
            {
                public override void HacerSonido()
                {
                    Console.WriteLine($"\n{Name} dice : !Miau!\n");
                }
        }
    }
}
