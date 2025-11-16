namespace EstudioFotografia.Infrastructure.Models
{
    public class AlbumModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public int SesionId { get; set; }
    }
}
