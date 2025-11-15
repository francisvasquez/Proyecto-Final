namespace EstudioFotografia.Models
{
    public class Entrega
    {
        public int Id { get; set; }
        public DateTime FechaEntrega { get; set; }

        public int SesionId { get; set; }
        public Sesion Sesion { get; set; }
    }
}
