using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasConC
{
    internal class Alumnos
    {
        public string NombreAlumno { get; set; }
        public string Carrera { get; set; }
        public string GradoScolar { get; set; }
        public int Edad { get; set; }
        public int Carnet { get; set; }

        public Alumnos(string nombreAlumno, string carrera, string gradoScolar, int edad, int carnet)
        {
            this.NombreAlumno = nombreAlumno;
            this.Carrera = carrera;
            this.GradoScolar = gradoScolar;
            this.Edad = edad;
            this.Carnet = carnet;  
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("EL alumno {0}," +
                " de la carrera {1}, de grado {2}, con edad{3}, y su carnet {4}",NombreAlumno,Carrera,GradoScolar,Edad,Carnet);
        }

    }
}
