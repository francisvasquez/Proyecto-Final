namespace EstudioFotografia.Models
{
    public class Foto
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
