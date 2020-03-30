using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02
{
    class Playlist
    {
        private string nombreplay;
        public string NombrePlay { get => nombreplay; set => nombreplay = value; }
        public List<Cancion> PlayList;
        Cancion k = new Cancion("(Cancion)", "(Cancion)", "(Cancion)", "(Cancion)");
        public Playlist(string NombrePlay, List<Cancion> PlayList)
        {
            this.NombrePlay = NombrePlay;
            this.PlayList = PlayList;
        }
        public void VerCancionesPlay()
        {
            PlayList.Add(k);
            Console.WriteLine(NombrePlay);
            foreach (Cancion i in PlayList)
            {
                Console.WriteLine(i.Informacion());
            }
            PlayList.Remove(k);
        }
    }
}
