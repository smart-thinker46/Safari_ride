using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class Album
    {
        public int ID { get; set; }
        public String AlbumName { get; set; }
        public string ArtistName { get; set; }
        public int Year { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }

        //later make a list<Tracks> songs
    }
}
