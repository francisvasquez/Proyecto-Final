using EstudioFotografia.Infrastructure.Context;
using EstudioFotografia.Infrastructure.Interfaces;
using EstudioFotografia.Infrastructure.Models;

namespace EstudioFotografia.Infrastructure.Repositories
{
    public class SesionRepository : BaseRepository<SesionModel>, ISesionRepository
    {
        public SesionRepository(EstudioContext context) : base(context)
        {
        }
    }
}
