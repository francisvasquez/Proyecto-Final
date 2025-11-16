namespace EstudioFotografia.Application.Dtos
{
    public class PaqueteDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int CantidadFotos { get; set; }
    }
}
