using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasConC
{
    internal class GradosScolares 
    {
        public string GradoEscolar { get; set; }
        public List<Alumnos> ListaAlumnos { get; set; }

        public GradosScolares(string gradoEscolar, List<Alumnos> listaAlumnos)
        {
            GradoEscolar = gradoEscolar;
            ListaAlumnos = listaAlumnos;
        }

    }
}
