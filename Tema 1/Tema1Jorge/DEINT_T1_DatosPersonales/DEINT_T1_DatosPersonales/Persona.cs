using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_T1_DatosPersonales
{


    internal class Persona
    {
        private static int personas = 0;

        public int personaID { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string direccion {  get; set; }
        public int telefono { get; set; }
        public int numeroHijos {  get; set; }

        public Persona (string nombre, string apellidos, string direccion, int telefono, int numeroHijos)
        {
            this.personaID = personas++;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefono = telefono;
            this.numeroHijos = numeroHijos;
        }
    }
}
