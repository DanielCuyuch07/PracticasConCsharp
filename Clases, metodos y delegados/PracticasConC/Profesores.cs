using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasConC
{
    internal class Profesores: Alumnos
    {
        public string NombreProfesor { get; set; }
        public string Carrera { get; set; }
        public string CargoDelGradoScolar { get; set; }
        public int Edad { get; set; }
        public int Carnet { get; set; }

        //public Profesores
        //    (string nombreProfesor, string carrera, string cargoDelGradoScolar, int edad, int carnet, string GradoScolar)
        //    :base( carrera, edad, carnet, GradoScolar)
        //{
        //    this.NombreProfesor = nombreProfesor;
        //    this.Carrera = carrera;
        //    this.CargoDelGradoScolar = cargoDelGradoScolar;
        //    this.Edad = edad;
        //    this.Carnet = carnet;
        //}


        // Los parametros del constructor deben coincidir con los el contructor de Alumnos
        public Profesores(string nombreProfesor, string carrera, string cargoDelGradoScolar, int edad, int carnet)
         : base(nombreProfesor, carrera, cargoDelGradoScolar, edad, carnet)
        {
            this.NombreProfesor = nombreProfesor;
            this.Carrera = carrera; 
            this.CargoDelGradoScolar = cargoDelGradoScolar;
            this.Edad = edad;   
            this.Carnet = carnet;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("EL profesor {0}," +
              " especializado en {1}, da clases en el grado  {2}, con una edad de {3},  su carnet {4}", NombreAlumno, Carrera, GradoScolar, Edad, Carnet);
        }






    }
}
