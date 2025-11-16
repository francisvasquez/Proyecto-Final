using EstudioFotografia.Infrastructure.Context;
using EstudioFotografia.Infrastructure.Interfaces;
using EstudioFotografia.Infrastructure.Models;

namespace EstudioFotografia.Infrastructure.Repositories
{
    public class ClienteRepository : BaseRepository<ClienteModel>, IClienteRepository
    {
        public ClienteRepository(EstudioContext context) : base(context)
        {
        }
    }
}
