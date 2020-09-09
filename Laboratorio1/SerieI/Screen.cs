using System;
using Tree_Bib;
using API_Tree.Models;

namespace Multi_Tree
{
    class Screen
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el grado del Árbol");
            int grado = 3; int.TryParse(Console.ReadLine(), out grado);

            while (true)
            {
                Console.WriteLine("Seleccione una opción \n\t1)Agregar Datos \n\t2)Salir");
                var option = 1; int.TryParse(Console.ReadLine(), out option);
                if (option == 1)
                {
                    //Ingresar valores
                    ArbolM<Movie> arbolitom = new ArbolM<Movie>(grado);
                    Movie movie = new Movie();
                    movie.director = null;
                    movie.imdbRating = 6.1;
                    movie.genre = null;
                    movie.releaseDate = "Jun 12 1998";
                    movie.rottenTomatoesRating = 0;
                    movie.title = "The Land Girls";

                    arbolitom.Insertar(movie);

                    Movie movie1 = new Movie();
                    movie1.director = null;
                    movie1.imdbRating = 6.9;
                    movie1.genre = "Drama";
                    movie1.releaseDate = "Aug 07 1998";
                    movie1.rottenTomatoesRating =  0;
                    movie1.title = "First Love, Last Rites";

                    arbolitom.Insertar(movie1);

                    Movie movie2 = new Movie();
                    movie2.director = null;
                    movie2.imdbRating = 3.4;
                    movie2.genre = "Drama";
                    movie2.releaseDate = "Oct 09 1998";
                    movie2.rottenTomatoesRating = 62;
                    movie2.title = "Slam";

                    arbolitom.Insertar(movie2);
                }
                else if (option == 2)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Ingrese un número válido.\n");
                }
            }
        }
    }
}
