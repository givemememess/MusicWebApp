namespace MusicWebApplication.Models.MusicModel
{
    public class Track
    {
        public int Id { get; set; }
        public float Time { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Music { get; set; }
        public string Information { get; set; }

        public Producer Producer { get; set; }
    }
}
