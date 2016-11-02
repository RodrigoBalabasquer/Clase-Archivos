using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serializacion
{
    class Program
    {
        static void Main()
        {
            Persona UnaPer = new Persona("Pedro");
            List<Persona> Listado = new List<Persona>();
            Listado.Add(new Persona("Rodrigo"));
            Listado.Add(new Persona("Gonzalo"));
            Alumno alum = new Alumno();
            alum._nombre = "Nestor";
            Aula UnAula = new Aula(4,Listado,alum,"aula 4");
            //Serializador.SerializarPersona(UnaPer);
            //Serializador.SerializarPersona(alum);//para que funcione es necesario el xmlinclude
            Serializador.SerializarGenerico(UnaPer);
            Serializador.SerializarListadoPersona(Listado);
            Serializador.SerializarAula(UnAula);
            Persona OtraPer = new Persona();
            Serializador.DescerializarGenerico(OtraPer);
            Console.WriteLine(OtraPer._nombre);
            Console.ReadKey();
        }
    }
}
