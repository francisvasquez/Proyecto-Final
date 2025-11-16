using EstudioFotografia.Infrastructure.Context;
using EstudioFotografia.Infrastructure.Interfaces;
using EstudioFotografia.Infrastructure.Models;

namespace EstudioFotografia.Infrastructure.Repositories
{
    public class PaqueteRepository : BaseRepository<PaqueteModel>, IPaqueteRepository
    {
        public PaqueteRepository(EstudioContext context) : base(context)
        {
        }
    }
}

