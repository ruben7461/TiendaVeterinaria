using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario
{
    class Animal
    {

        public string Nombre { get; set; }
        public char Sexo { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public int Chip { get; set; }
        public string fechaNacimiento { get; set; }
        public int duenio { get; set; }


        public Animal() { }

        public Animal(string anNombre, char sexo, string Especie, string raza,int chip,string nacimiento,int duenio)

        {

            /////////
            this.Nombre = anNombre;
            this.Sexo = sexo;
            this.Especie = Especie;
            this.Raza = raza;
            this.Chip = chip;
            this.fechaNacimiento = fechaNacimiento;
            this.duenio = duenio;
        }

    }
}
}
