namespace EstudioFotografia.Infrastructure.Models
{
    public class SesionModel
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public int PaqueteId { get; set; }
    }
}
