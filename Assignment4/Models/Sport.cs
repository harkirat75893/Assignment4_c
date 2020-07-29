using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class Sport
    {
        public int Id { get; set; }
        public string SportName { get; set; }
        public int NoOFPlayers { get; set; }
        public string FavouritePlayer { get; set; }

        public int FavouritePlayerJerseyNumber { get; set; }

        public string Team { get; set; }
    }
}
