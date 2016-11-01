using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Escritura_en_archivos;

namespace WGuardador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {   
            Persona person;
            List<Persona> Lista;
            bool estado;
            estado = Guardador.GuardarPersona(person = new Persona(this.txtNombre.Text, this.txtClave.Text));
            if (estado)
            {
                Lista = Guardador.RetornarListado();
                lbxLista.Items.Clear();
                this.CargarListado(Lista);
            }
            else 
            {
                
            }
        }
        private void CargarListado(List<Persona> personas)
        {
            foreach (Persona item in personas)
            {
                lbxLista.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
