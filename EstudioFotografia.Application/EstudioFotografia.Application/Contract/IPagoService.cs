using EstudioFotografia.Application.Dtos;

namespace EstudioFotografia.Application.Contract
{
    public interface IPagoService
    {
        Task<IEnumerable<PagoDto>> GetAllAsync();
        Task<PagoDto?> GetByIdAsync(int id);
        Task<PagoDto> CreateAsync(PagoDto dto);
        Task<PagoDto> UpdateAsync(int id, PagoDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
