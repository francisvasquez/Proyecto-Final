using Microsoft.EntityFrameworkCore;
using EstudioFotografia.Infrastructure.Models;

namespace EstudioFotografia.Infrastructure.Context
{
    public class EstudioContext : DbContext
    {
        public EstudioContext(DbContextOptions<EstudioContext> options) : base(options)
        {
        }

        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<SesionModel> Sesiones { get; set; }
        public DbSet<PaqueteModel> Paquetes { get; set; }
        public DbSet<PagoModel> Pagos { get; set; }
        public DbSet<EntregaModel> Entregas { get; set; }
        public DbSet<AlbumModel> Albums { get; set; }
        public DbSet<FotoModel> Fotos { get; set; }
    }
}
