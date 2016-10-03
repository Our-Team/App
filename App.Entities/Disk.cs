using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class Disk
    {
        public static List<Track> ListOfTracks { get; set; }
        public List<Guid> NumberOfTracks { get; set; }
        public string Name { get; set; }
        public DateTime DateOfRelease { get; set; }

        public string Description { get; set; }
        public Guid Id { get; set; }
    }
}
