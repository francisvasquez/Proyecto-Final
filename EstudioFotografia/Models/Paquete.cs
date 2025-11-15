namespace EstudioFotografia.Models
{
    public class Paquete
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int CantidadFotos { get; set; }

        public ICollection<Sesion> Sesiones { get; set; }
    }
}
