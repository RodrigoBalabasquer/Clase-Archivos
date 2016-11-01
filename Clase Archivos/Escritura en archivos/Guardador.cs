using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Escritura_en_archivos
{
    public static class Guardador
    {
        public static bool GuardarPersona(Persona person)
        {   
            bool estado = true;
            StreamWriter archivo = null;
            try
            {
                archivo = new StreamWriter("Personas.txt", true);
                archivo.Write(person.ToString());
            }
            catch (Exception)
            {
                estado = false;    
            }
            finally
            {
                archivo.Close();
            }
            return estado;
        }
        public static Persona LeerUnaPersona()
        {
            Persona pers1;
            string[] ListaDePersona;
            StreamReader archivo = null;
            string dato;
            try
            {
                archivo = new StreamReader("Personas.txt");
                dato = archivo.ReadLine();
                ListaDePersona = dato.Split(',');
                pers1 = new Persona(ListaDePersona[0], ListaDePersona[1]);
            }
            catch (Exception)
            {
                pers1 = null;
            }
            finally
            {
                archivo.Close();   
            }
            return pers1;
        }
        public static List<Persona> RetornarListado() 
        {   
            string[] ListaDePersona;
            List<Persona> MiListado = null;
            try
            {
                MiListado = new List<Persona>();
                using (StreamReader lector = new StreamReader("Personas.txt"))
                {
                    string Reglon;
                    while((Reglon = lector.ReadLine()) != null)
                    {
                        ListaDePersona = Reglon.Split(',');
                        MiListado.Add(new Persona(ListaDePersona[0], ListaDePersona[1]));
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            return MiListado;
        }
    }
}
