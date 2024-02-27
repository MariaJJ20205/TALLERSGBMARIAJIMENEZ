using System;
using System.Collections.Generic;

namespace TallerSgbMariaJiménez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void CatalogoLibros()
        {
          
                Dictionary<string, Libro> catalogoLibros = new Dictionary<string, Libro>();


                Libro libro1 = new Libro ("Cartas de amor a los muertos", " Ava Dellaira", "2014", true) ;
                catalogoLibros.Add(libro1.Titulo, libro1);

                Libro libro2 = new Libro("Las mujeres que aman demasiado", "Robin Norwood", "1985", true);
                catalogoLibros.Add(libro2.Titulo, libro2);

                Libro libro3 = new Libro("El corazón delator", "Edgar Allan Poe", "1843", true);
                catalogoLibros.Add(libro3.Titulo, libro3);

        }
    }
}
