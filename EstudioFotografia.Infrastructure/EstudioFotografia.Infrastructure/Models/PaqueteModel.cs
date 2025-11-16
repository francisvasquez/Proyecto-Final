namespace EstudioFotografia.Infrastructure.Models
{
    public class PaqueteModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Precio { get; set; }
        public int CantidadFotos { get; set; }
    }
}
