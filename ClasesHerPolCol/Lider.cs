using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHerPolCol
{
    internal class Lider : Persona, Interface1 
    {
        public override string saludo()
        {
            return "Hola, yo soy el LIDER";
        }
        public string buenSalario()
        {
            return "Tiene un muy buen salario!";
        }
    }
}
