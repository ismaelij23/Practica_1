using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHerPolCol
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public virtual string saludo()
        {
            return "Hola soy una PERSONA";
        }
    }
}
