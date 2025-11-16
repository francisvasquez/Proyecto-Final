using EstudioFotografia.Infrastructure.Context;
using EstudioFotografia.Infrastructure.Models;
using EstudioFotografia.Infrastructure.Interfaces;

namespace EstudioFotografia.Infrastructure.Repositories
{
    public class AlbumRepository : BaseRepository<AlbumModel>, IAlbumRepository
    {
        public AlbumRepository(EstudioContext context) : base(context)
        {
        }
    }
}
