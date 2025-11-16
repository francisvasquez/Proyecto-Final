namespace EstudioFotografia.Application.Dtos
{
    public class PagoDto
    {
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public int SesionId { get; set; }
    }
}
