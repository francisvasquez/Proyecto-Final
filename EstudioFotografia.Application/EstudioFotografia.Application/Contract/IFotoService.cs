using EstudioFotografia.Application.Dtos;

namespace EstudioFotografia.Application.Contract
{
    public interface IFotoService
    {
        Task<IEnumerable<FotoDto>> GetAllAsync();
        Task<FotoDto?> GetByIdAsync(int id);
        Task<FotoDto> CreateAsync(FotoDto dto);
        Task<FotoDto> UpdateAsync(int id, FotoDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
