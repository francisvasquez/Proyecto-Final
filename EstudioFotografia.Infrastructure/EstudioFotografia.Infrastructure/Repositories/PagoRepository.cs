using EstudioFotografia.Infrastructure.Context;
using EstudioFotografia.Infrastructure.Interfaces;
using EstudioFotografia.Infrastructure.Models;

namespace EstudioFotografia.Infrastructure.Repositories
{
    public class PagoRepository : BaseRepository<PagoModel>, IPagoRepository
    {
        public PagoRepository(EstudioContext context) : base(context)
        {
        }
    }
}
