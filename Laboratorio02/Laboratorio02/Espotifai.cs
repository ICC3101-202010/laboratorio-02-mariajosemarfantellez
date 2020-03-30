using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02
{
    class Espotifai
    {
        List<Cancion> MiLista = new List<Cancion>();
        List<Cancion> CriterioCancion = new List<Cancion>();
        List<Playlist> Almacenamiento = new List<Playlist>();
        Cancion z = new Cancion("(Cancion)", "(Cancion)", "(Cancion)", "(Cancion)");
        public Espotifai()
        {
        }

        public bool AgregarCancion(Cancion cancion)
        {
            MiLista.Add(z);
            int contador = 0;
            foreach (Cancion i in MiLista)
            {
                if (i.Nombre == cancion.Nombre && i.Album == cancion.Album && i.Artista == cancion.Artista && i.Genero == cancion.Genero)
                {
                    contador += 1;

                }
                else
                {
                    contador = contador + 0;
                }
            }
            if (contador == 0)
            {
                MiLista.Remove(z);
                Console.WriteLine("\nLa cancion fue añadida con exito\n");
                MiLista.Add(cancion);
                return true;
            }
            else
            {
                MiLista.Remove(z);
                Console.WriteLine("\nLa cancion ya esta en la lista\n");
                return false;
            }

        }
        public void VerCanciones()
        {
            MiLista.Add(z);
            foreach (Cancion i in MiLista)
            {
                Console.WriteLine(i.Informacion());
            }
            MiLista.Remove(z);
        }        
        

        public List<Cancion> CancionesPorCriterio(String criterio, String valor)
        {
            CriterioCancion.Clear();
            string crit = criterio.ToLower();
            if (crit == "genero")
            {
                foreach (Cancion i in MiLista)
                {
                    if (i.Genero == valor)
                    {
                        CriterioCancion.Add(i);
                    }
                    else
                    {
                    }
                }
                if (CriterioCancion.Count == 0)
                {
                    Console.WriteLine("\nNo existen canciones con ese genero\n");
                    return CriterioCancion;
                }
                else
                {
                    return CriterioCancion;
                }

            }
            else if (crit == "artista")
            {
                foreach (Cancion i in MiLista)
                {
                    if (i.Artista == valor)
                    {
                        CriterioCancion.Add(i);
                    }
                    else
                    {
                    }
                }
                if (CriterioCancion.Count == 0)
                {
                    Console.WriteLine("\nNo existen canciones con ese artista\n");
                    return CriterioCancion;
                }
                else
                {
                    return CriterioCancion;
                }

            }
            else if (crit == "album")
            {
                foreach (Cancion i in MiLista)
                {
                    if (i.Album == valor)
                    {
                        CriterioCancion.Add(i);
                    }
                    else
                    {
                    }
                }
                if (CriterioCancion.Count == 0)
                {
                    Console.WriteLine("\nNo existen canciones con ese album\n");
                    return CriterioCancion;
                }
                else
                {
                    return CriterioCancion;
                }

            }
            else if (crit == "nombre")
            {
                foreach (Cancion i in MiLista)
                {
                    if (i.Nombre == valor)
                    {
                        CriterioCancion.Add(i);
                    }
                    else
                    {
                    }
                }
                if (CriterioCancion.Count == 0)
                {
                    Console.WriteLine("\nNo existen canciones con ese nombre\n");
                    return CriterioCancion;
                }
                else
                {
                    return CriterioCancion;
                }

            }
            else 
            {
                Console.WriteLine("\n¡Error! Ese criterio no existe\n");
                return CriterioCancion;
            }


        }
        public void VerCanciones1()
        {
            foreach (Cancion i in CriterioCancion)
            {
                Console.WriteLine(i.Informacion());
            }

        }
        public bool GenerarPlaylist(String criterioplay, String valorCriterio, String nombrePlaylist)
        {
            string critplay = criterioplay.ToLower();
            string valplay = valorCriterio.ToLower();
            string nomplay = nombrePlaylist.ToLower();
            CriterioCancion.Clear();
            if (critplay == "genero")
            {
                foreach (Cancion i in MiLista)
                {
                    if (i.Genero == valorCriterio)
                    {
                        CriterioCancion.Add(i);
                    }
                    else
                    {
                    }
                }
                if (CriterioCancion.Count == 0)
                {
                    Console.WriteLine("\nNo existen canciones con ese genero\n");
                    return false;
                }
                else
                {
                }
            }
            else if (critplay == "artista")
            {
                foreach (Cancion i in MiLista)
                {
                    if (i.Artista == valorCriterio)
                    {
                        CriterioCancion.Add(i);
                    }
                    else
                    {
                    }
                }
                if (CriterioCancion.Count == 0)
                {
                    Console.WriteLine("\nNo existen canciones con ese artista\n");
                    return false;
                }
                else
                {
                }
            }
            else if (critplay == "album")
            {
                foreach (Cancion i in MiLista)
                {
                    if (i.Album == valorCriterio)
                    {
                        CriterioCancion.Add(i);
                    }
                    else
                    {
                    }
                }
                if (CriterioCancion.Count == 0)
                {
                    Console.WriteLine("\nNo existen canciones con ese album\n");
                    return false;
                }
                else
                {
                }
            }
            else if (critplay == "nombre")
            {
                foreach (Cancion i in MiLista)
                {
                    if (i.Nombre == valorCriterio)
                    {
                        CriterioCancion.Add(i);
                    }
                    else
                    {
                    }
                }
                if (CriterioCancion.Count == 0)
                {
                    Console.WriteLine("\nNo existen canciones con ese nombre\n");
                    return false;
                }
                else
                {
                }
            }
            else
            {
                Console.WriteLine("\nEse criterio no existe\n");
                return false;
            }
            Playlist añadir = new Playlist(nombrePlaylist,CriterioCancion);
            if (Almacenamiento.Count == 0)
            {
                Console.WriteLine("\nLas canciones de la playlist son las siguientes: \n");
                foreach (Cancion i in CriterioCancion)
                {
                    Console.WriteLine(i.Informacion());
                }
                Almacenamiento.Add(añadir);
                Console.WriteLine("\nLa PLaylist fue agregada con exito\n");

                return true;
            }
            else
            {
                int c11 = 0;
                foreach (Playlist i in Almacenamiento)
                {
                    if (i.NombrePlay == nombrePlaylist)
                    {
                        c11 += 1;
                    }
                    else
                    {
                    }
                }
                if (c11 != 0)
                {
                    Console.WriteLine("\nLa Playlist ya existe\n");
                    return false;
                }
                else
                {
                    Console.WriteLine("\nLas canciones de la playlist son las siguientes: \n");
                    foreach (Cancion i in CriterioCancion)
                    {
                        Console.WriteLine(i.Informacion());
                    }
                    Almacenamiento.Add(añadir);
                    Console.WriteLine("\nLa Playlist fue agregada con exito\n");
                    return true;
                }
            }
        }
        public String VerMisPlaylists()
        {
            if (Almacenamiento.Count() == 0)
            {
                return ("\nNo hay playlists\n");

            }
            else
            {
                foreach (Playlist i in Almacenamiento)
                {
                    Console.WriteLine("Playlist : " + " " + i.NombrePlay);
                    i.VerCancionesPlay();
                }
                return ("\nTodas las playlist fueron desplegadas\n");
            }

        }
    }
}

