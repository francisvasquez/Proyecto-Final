using EstudioFotografia.Application.Dtos;

namespace EstudioFotografia.Application.Contract
{
    public interface IPaqueteService
    {
        Task<IEnumerable<PaqueteDto>> GetAllAsync();
        Task<PaqueteDto> GetByIdAsync(int id);
        Task<PaqueteDto> CreateAsync(PaqueteDto dto);
        Task<PaqueteDto> UpdateAsync(int id, PaqueteDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
