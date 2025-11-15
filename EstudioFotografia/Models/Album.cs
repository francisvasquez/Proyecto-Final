using System.Collections.Generic;

namespace EstudioFotografia.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public int SesionId { get; set; }
        public Sesion Sesion { get; set; }

        public ICollection<Foto> Fotos { get; set; }
    }
}
