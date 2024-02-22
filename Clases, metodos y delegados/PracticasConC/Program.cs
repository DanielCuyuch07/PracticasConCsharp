using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasConC
{
    /*
        `` Tema Escuela 30  -- 20/02/24
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Alumnos>> gradosPorAlumno = new Dictionary<string, List<Alumnos>>();

            List<Alumnos> gradoDiverFour = new List<Alumnos>()
            {
                new Alumnos("Andy Daniel Cuyuch", "Informatica", "4 diversificado", 12, 20181234),
                new Alumnos("Briseyda Yulianna Boror", "Medicina", "4 diversificado", 20, 2018112)
            };

            gradosPorAlumno["4 diversificado"] = gradoDiverFour;


            List<Alumnos> gradoDiverFive = new List<Alumnos>()
            {
                new Alumnos("Josselin Mateo", "Medicina", "5 diversificado", 20, 2018112),
                new Alumnos("Alexander Cruz", "Informatica", "5 diversificado", 20, 20181234)
            };

            gradosPorAlumno["5 Diversificado"] = gradoDiverFive;

            foreach (var kvp in gradosPorAlumno)
            {
                // Obtenemos la clave
                Console.WriteLine($"Alumnos en el grado {kvp.Key}:");

                // Obtenemos el valor
                foreach (var alumno in kvp.Value) {
                    Console.WriteLine($"Nombre: {alumno.NombreAlumno}, Carrera: {alumno.Carrera}, Grado: {alumno.GradoScolar}, Edad: {alumno.Edad}, Carnet: {alumno.Carnet}");
                }

            }

            Profesores profesor = 
                new Profesores("Josue noj","Informatica","4 diversificado",22,2017403);

            Profesores profesor1 =
                 new Profesores("Josue noj", "Informatica", "5 diversificado", 22, 2017403);



            Console.ReadLine();

        }
    }
}
