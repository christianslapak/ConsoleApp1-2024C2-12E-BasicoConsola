using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_2024C2_12E_BasicoConsola
{
    internal class Persona
    {
        public int DNI { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }

        public DateTime FechaNac { get; set; }

        public string MostrarDatos()
        {
            string mensaje;
            mensaje = "Los datos son: " + DNI + " " + Apellido + " " + Nombre;
            return mensaje;
        }
    }
}
