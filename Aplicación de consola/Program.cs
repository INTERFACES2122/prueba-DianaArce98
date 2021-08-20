using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicación_de_consola.Clases;

namespace Aplicación_de_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arreglo = new int[5];    i<lista.Count

            //List<int> lista = new List<int> { 4, 6 };
            //lista.Add(7);

            //foreach(int i in lista)
            //{
            //    Console.WriteLine("valor " + i);
            //}

            Alumno alumno = new Alumno("284742", "Diana Ivonne", "Arce Ochoa");
            Alumno alumno2 = new Alumno();
            Materia materia = new Materia();

            Console.WriteLine(alumno.ObtenerInformacion());

            materia.Nombre = "Interfaces";
            materia.NoAlumnos = 15;
            materia.Codigo = "xd"; 

            Console.WriteLine(materia.NoAlumnos);
            Console.WriteLine(materia.Codigo);

            Console.Read();
        }
    }
}
