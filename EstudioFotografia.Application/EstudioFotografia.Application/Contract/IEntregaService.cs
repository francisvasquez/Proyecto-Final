using EstudioFotografia.Application.Dtos;

namespace EstudioFotografia.Application.Contract
{
    public interface IEntregaService
    {
        Task<IEnumerable<EntregaDto>> GetAllAsync();
        Task<EntregaDto?> GetByIdAsync(int id);
        Task<EntregaDto> CreateAsync(EntregaDto dto);
        Task<EntregaDto> UpdateAsync(int id, EntregaDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
