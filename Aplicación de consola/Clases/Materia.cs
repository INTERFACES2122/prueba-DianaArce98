using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicación_de_consola.Clases
{
    public class Materia
    {
        /// <summary>
        /// Atributo del nombre de la materia.
        /// </summary>
        private string nombre;
        private int no_alumnos;
        public string Codigo { get; set; }

        //public Materia() { }

        /// <summary>
        /// Método de acceso al atributo nombre.
        /// </summary>
        public string Nombre 
        {
            get
            {
                return nombre; 
            }
            set
            {
                nombre = value; 
            }
        }

        public int NoAlumnos
        {
            get
            {
                return no_alumnos; 
            }
            set
            {
                no_alumnos = value; 
            }
        }
    }
}
