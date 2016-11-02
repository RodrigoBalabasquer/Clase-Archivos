using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Serializacion
{   
    [XmlInclude(typeof(Alumno))] 
    public class Persona:ISerializable2016
    {
        public string _nombre;
        public Persona() 
        {

        }
        public Persona(string nombre) 
        {
            this._nombre = nombre;
        }

        public bool Serializar()
        {
            try
            {
                Serializador.SerializarPersona(this);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }


        public bool Desserializar()
        {
            try
            {
                Persona P = Serializador.DeserealizarPersona();
                this._nombre = P._nombre;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
