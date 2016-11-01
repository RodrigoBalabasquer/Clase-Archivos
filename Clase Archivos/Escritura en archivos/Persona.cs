using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escritura_en_archivos
{
    public class Persona
    {
        public string _nombre;
        public string _clave;
        public Persona(string nombre, string clave) 
        {
            this._nombre = nombre;
            this._clave = clave;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this._nombre+", "+this._clave);
            return sb.ToString();
        }
    }
}
