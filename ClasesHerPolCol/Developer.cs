using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHerPolCol
{
    internal class Developer : Persona, Interface1
    {
        public string Labor { get; set; }
        public override string ToString()
        {
            return "El labor de " + Nombre + " es " + Labor;
        }
        public override string saludo()
        {
            return "Hola soy un DESARROLLADOR";
        }

        public string AñosExp { get; set; }

        public string buenSalario()
        {
            return "TIENE UN BUEN SALARIOOO";
        }

    }
}
