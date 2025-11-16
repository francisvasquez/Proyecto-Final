using EstudioFotografia.Application.Dtos;

namespace EstudioFotografia.Application.Contract
{
    public interface ISesionService
    {
        Task<IEnumerable<SesionDto>> GetAllAsync();
        Task<SesionDto?> GetByIdAsync(int id);
        Task<SesionDto> CreateAsync(SesionDto dto);
        Task<SesionDto> UpdateAsync(int id, SesionDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
