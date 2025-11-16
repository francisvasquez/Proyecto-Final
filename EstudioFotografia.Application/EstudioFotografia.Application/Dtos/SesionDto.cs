namespace EstudioFotografia.Application.Dtos
{
    public class SesionDto
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public int PaqueteId { get; set; }
    }
}
