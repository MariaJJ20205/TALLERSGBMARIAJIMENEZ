using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerSgbMariaJiménez
{
    public class Libro
    {
        
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string AnioPublicacion { get; set; }
        public bool Disponibilidad { get; set; }
        
        public Libro(string titulo, string autor, string anioPublicacion, bool disponibilidad)
        {
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anioPublicacion;
            Disponibilidad = disponibilidad;
        }
    }
}
