using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Escritura_en_archivos
{
    class Program
    {
        static void Main()
        {   
            //Creacion de archivo, con el true el archivo agrega cada vez que se ejecuta el main, con el false se sobrescribe
            StreamWriter escritor = new StreamWriter("archivo.txt",true);
            escritor.WriteLine("adasd");
            escritor.Close();
            Persona persona = new Persona("dfgdfgo", "****");
            Guardador.GuardarPersona(persona);
            Persona otraPersona = Guardador.LeerUnaPersona();
            Console.WriteLine(otraPersona);
            List<Persona> Lista = Guardador.RetornarListado();
            foreach (Persona item in Lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}


