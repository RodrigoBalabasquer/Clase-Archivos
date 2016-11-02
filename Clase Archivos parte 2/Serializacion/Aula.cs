using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serializacion
{
    public class Aula
    {
        public int _numero;
        private List<Persona> _alumnos;// para que una lista privada o protegida se serealize solo debe tener el get
        public Persona _profesor;
        private string _nombreAula;// para que se serealize un atributo privado o protegido debe tener un propiedad con set y get
        public Aula() 
        {
            this._alumnos = new List<Persona>();
        }
        public Aula(int numero, List<Persona> lista,Persona profesor)
        {
            this._numero = numero;
            this._alumnos = lista;
            this._profesor = profesor;
        }
        public Aula(int numero, List<Persona> lista, Persona profesor,string nombre):this(numero,lista,profesor)
        {
            this.Nombre = nombre;
        }
        public string Nombre
        {
            set 
            {
                this._nombreAula = value;
            }
            get
            {
                return this._nombreAula;
            }
        }
        public List<Persona> ListaPersonas 
        {
            get 
            {
                return this._alumnos;
            }
        }
    }
}
