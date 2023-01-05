using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHerPolCol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer dev1 = new Developer();
            dev1.Nombre = "Ismael";
            dev1.Apellido = "Juaristi";
            dev1.Edad = 26;
            Developer dev2 = new Developer();
            dev2.Nombre = "Julian";
            dev2.Apellido = "Gonzales";
            dev2.Edad = 22;

            Persona per1 = new Persona();

            Lider lid1 = new Lider();

            List<Developer> listaDevs = new List<Developer>();
            listaDevs.Add(dev1);
            listaDevs.Add(dev2);

            Console.WriteLine("La cantidad de Devs es " + listaDevs.Count);
            dev1.Nombre = "Fabricio";
            listaDevs[0].Nombre = "Roman";
            Console.WriteLine("La edad del dev " + listaDevs[0].Nombre + " es " + listaDevs[0].Edad + " años");

            foreach (Developer item in listaDevs)
            {
                Console.WriteLine("El nombre del Dev es " + item.Nombre + ", y tiene " + item.Edad + " años...");
            }

            listaDevs.RemoveAt(1);
            listaDevs.Remove(dev1);
            Console.WriteLine("La cantidad de Devs es " + listaDevs.Count);
            Console.WriteLine("");
            Console.WriteLine("SOBREESCRITURA DE MÉTODOS: ");

            // SOBREESCRITURA DE MÉTODOS: 
            Persona p2 = new Persona();
            Developer dev3 = new Developer();
            dev3.Labor = "Desarrollar apps";
            dev3.Nombre = "Jaimito";
            dev3.AñosExp = "6 años";
            Console.WriteLine(p2.ToString());
            Console.WriteLine(dev3.ToString());
            Console.WriteLine(dev3.saludo());

            List<Persona> listaPersonas = new List<Persona>();
            listaPersonas.Add(dev1);
            listaPersonas.Add(dev2);
            listaPersonas.Add(dev3);
            listaPersonas.Add(new Tester());
            listaPersonas.Add(new Lider());
            listaPersonas.Add(per1);
            listaPersonas.Add(p2);

            //JERARQUÍA: SOLUCIONES
            Persona p3 = dev3;
            Console.WriteLine(p3.saludo());
            // Console.writeLine(p3.AñosExp); IMPOSIBLE ACCEDER...
            Console.WriteLine(dev3.AñosExp);
            Developer devAux = (Developer)p3;
            Console.WriteLine(devAux.AñosExp);
            devAux.AñosExp = "899 años de experiencia";
            Console.WriteLine(devAux.AñosExp);
            Console.WriteLine(dev3.AñosExp);
            Console.WriteLine("");

            listaPersonas.Add(p3);
            listaPersonas.Add(devAux);

            //ACÁ SE VE UN EJEMPLO DE POLIMORFISMO:
            foreach (Persona item in listaPersonas)
            {
                Console.WriteLine(item.saludo());
            }

            Console.WriteLine("");

            //INTERFACES: (No son clases, o sea, no puedo -> new Interface1)
            // Solo puedo agregarle a la lista clases de tipo Lider y Developer, porque son las únicas que cuentan
            // con la interface.
            List<Interface1> listaBuenosSalarios = new List<Interface1>();
            listaBuenosSalarios.Add(new Lider());
            listaBuenosSalarios.Add(new Lider());
            listaBuenosSalarios.Add(dev3);
            // NO ES POSIBLE -> listaBuenosSalarios.Add(new Developer());

            Console.WriteLine(listaBuenosSalarios[2].buenSalario());
            Console.WriteLine(listaPersonas[2].Nombre);
            
            

            Console.ReadKey();

        }
    }
}
