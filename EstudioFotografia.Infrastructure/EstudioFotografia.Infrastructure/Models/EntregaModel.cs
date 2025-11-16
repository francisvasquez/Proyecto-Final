namespace EstudioFotografia.Infrastructure.Models
{
    public class EntregaModel
    {
        public int Id { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int SesionId { get; set; }
    }
}
