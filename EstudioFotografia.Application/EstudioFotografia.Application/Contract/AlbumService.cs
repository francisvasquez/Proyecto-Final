using EstudioFotografia.Application.Dtos;

namespace EstudioFotografia.Application.Contract
{
    public interface IAlbumService
    {
        Task<IEnumerable<AlbumDto>> GetAllAsync();
        Task<AlbumDto> GetByIdAsync(int id);
        Task<AlbumDto> CreateAsync(AlbumDto dto);
        Task<AlbumDto> UpdateAsync(int id, AlbumDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
