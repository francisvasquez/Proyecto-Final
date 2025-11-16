using EstudioFotografia.Infrastructure.Context;
using EstudioFotografia.Infrastructure.Interfaces;
using EstudioFotografia.Infrastructure.Models;

namespace EstudioFotografia.Infrastructure.Repositories
{
    public class EntregaRepository : BaseRepository<EntregaModel>, IEntregaRepository
    {
        public EntregaRepository(EstudioContext context) : base(context)
        {
        }
    }
}
