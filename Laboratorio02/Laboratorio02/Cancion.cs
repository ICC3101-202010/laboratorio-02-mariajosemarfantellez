using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02
{
    class Cancion
    {
        private string nombre;
        private string album;
        private string artista;
        private string genero;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Album { get => album; set => album = value; }
        public string Artista { get => artista; set => artista = value; }
        public string Genero { get => genero; set => genero = value; }

        public Cancion(string Nombre, string Album, string Artista, string Genero)
        {
            this.Nombre = Nombre;
            this.Album = Album;
            this.Artista = Artista;
            this.Genero = Genero;
        }

        public string Informacion()
        {
            return ("Nombre: " + Nombre + ", " + "Album: " + Album + ", " + "Artista: " + Artista + ", " + "Genero: " + Genero);
        }
    }

    
}
