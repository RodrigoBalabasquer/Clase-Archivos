using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Serializacion
{
    public class Serializador
    {
        public static void SerializarPersona(Persona per)
        {
            //XmlTextWriter();
            //XmlSerializer
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("Persona.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Persona));//Siempre tendremos que tener un constructor por defecto en la clase correspondiente
                    serializador.Serialize(escritor, per);
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
        public static Persona DeserealizarPersona() 
        {   
            Persona miPersona = null;
            try
            {
                using (XmlTextReader lector = new XmlTextReader("Persona.xml"))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Persona));//Siempre tendremos que tener un constructor por defecto en la clase correspondiente
                    miPersona = (Persona)serializador.Deserialize(lector);
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return miPersona;
        }
        public static void SerializarListadoPersona(List<Persona> Lista)
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("ListadoDePersonas.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<Persona>));//Siempre tendremos que tener un constructor por defecto en la clase correspondiente
                    serializador.Serialize(escritor, Lista);
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
        public static void SerializarAula(Aula aula)
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("Aula.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Aula));
                    serializador.Serialize(escritor, aula);
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
        public static bool SerializarGenerico(ISerializable2016 obj) 
        {
            return obj.Serializar();
        }
        public static bool DescerializarGenerico(ISerializable2016 obj)
        {
            return obj.Desserializar();
        }
    }
}
