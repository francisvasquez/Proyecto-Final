namespace EstudioFotografia.Infrastructure.Models
{
    public class PagoModel
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public int SesionId { get; set; }
    }
}

