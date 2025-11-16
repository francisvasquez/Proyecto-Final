namespace EstudioFotografia.Application.Dtos
{
    public class AlbumDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public int SesionId { get; set; }
    }
}
