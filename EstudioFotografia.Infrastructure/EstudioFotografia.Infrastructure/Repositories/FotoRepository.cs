using EstudioFotografia.Infrastructure.Context;
using EstudioFotografia.Infrastructure.Interfaces;
using EstudioFotografia.Infrastructure.Models;

namespace EstudioFotografia.Infrastructure.Repositories
{
    public class FotoRepository : BaseRepository<FotoModel>, IFotoRepository
    {
        public FotoRepository(EstudioContext context) : base(context)
        {
        }
    }
}
