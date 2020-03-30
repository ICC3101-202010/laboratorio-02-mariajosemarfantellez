using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Espotifai listado = new Espotifai();
            Console.WriteLine("Hola, Bienvenido a Espotifai\n");

            while (true)
            {

                Console.WriteLine("\nSi desea agregar una cancion presione a\n");
                Console.WriteLine("Si desea ver las canciones existentes presione b\n");
                Console.WriteLine("Si desea ver canciones por criterio presione c\n");
                Console.WriteLine("Si desea agregar Playlist presione d\n");
                Console.WriteLine("Si desea ver las PLaylist presione e\n");
                Console.WriteLine("Si desea salir del menu presione f\n");
                string respuesta = Console.ReadLine();


                if (respuesta == "a")
                {
                    Console.WriteLine("\nDiga el nombre de la canción\n ");
                    string a = Console.ReadLine();
                    Console.WriteLine("\nDiga el album de la canción\n ");
                    string b = Console.ReadLine();
                    Console.WriteLine("\nDiga el artista de la canción\n ");
                    string c = Console.ReadLine();
                    Console.WriteLine("\nDiga el género de la canción\n ");
                    string d = Console.ReadLine();
                    Cancion c1 = new Cancion(a, b, c, d);
                    listado.AgregarCancion(c1);

                }
                else if (respuesta == "b")
                {
                    Console.WriteLine("\nLa lista de canciones es la siguiente\n");
                    listado.VerCanciones();

                }
                else if (respuesta == "c")
                {
                    Console.WriteLine("\nDiga el criterio: \n");
                    string q = Console.ReadLine();
                    if (q.ToLower() != "genero" && q.ToLower() != "album" && q.ToLower() != "artista" && q.ToLower() != "nombre")
                    {
                        string n = "n";
                        listado.CancionesPorCriterio(q, n);
                        listado.VerCanciones1();
                    }
                    else
                    {
                        Console.WriteLine("\nDiga el valor: \n");
                        string qw = Console.ReadLine();
                        listado.CancionesPorCriterio(q, qw);
                        listado.VerCanciones1();
                    }
                }
                else if (respuesta == "d")
                {
                    Console.WriteLine("\nIngrese el nombre de la Playlist\n");
                    string nombreplaylist = Console.ReadLine();
                    Console.WriteLine("\nIngrese el criterio por el cual desea crear la Playlist\n");
                    string criterioplaylist = Console.ReadLine();
                    Console.WriteLine("\nIngrese el valor del criterio\n");
                    string valorcriterioplaylist = Console.ReadLine();
                    listado.GenerarPlaylist(criterioplaylist, valorcriterioplaylist, nombreplaylist);
                }
                else if (respuesta == "e")
                {
                    listado.VerMisPlaylists();
                }

                else if (respuesta == "f")
                {
                    Console.WriteLine("\nEl programa ha finalizado, que tenga un buen día\n");
                    break;
                }
                else
                {
                    Console.WriteLine("\nEsa opción no existe, intente denuevo\n");
                }

            }

            Console.ReadLine();



        }



                  

    }
}
