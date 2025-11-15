namespace EstudioFotografia.Models
{
    public class Sesion
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int PaqueteId { get; set; }
        public Paquete Paquete { get; set; }

        public Album Album { get; set; }
    }
}
