namespace EstudioFotografia.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }

        public int SesionId { get; set; }
        public Sesion Sesion { get; set; }
    }
}
