using System.Collections.Generic;

namespace MusicWebApplication.Models.MusicModel
{
    public class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }

        public List<Track> Tracks { get; set; }
        public Producer()
        {
            Tracks = new List<Track>();
        } 
    }
}
