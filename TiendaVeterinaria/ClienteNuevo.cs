using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario
{
    class ClienteNuevo
    {

       
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public int Telefono { get; set; }

        public ClienteNuevo() { }

        public ClienteNuevo( string pNombre, string pApellido, string DNI, int Telefono)

        {
           
            /////////
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.DNI = DNI;
            this.Telefono = Telefono;
        }

    }
}
