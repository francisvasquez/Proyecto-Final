using EstudioFotografia.Application.Contract;
using EstudioFotografia.Application.Core;
using EstudioFotografia.Application.Dtos;
using EstudioFotografia.Infrastructure.Context;
using EstudioFotografia.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudioFotografia.Application.Service
{
    public class AlbumService : BaseService, IAlbumService
    {
        private readonly EstudioContext _context;

        public AlbumService(EstudioContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AlbumDto>> GetAllAsync()
        {
            var data = await _context.Albums.ToListAsync();

            return data.Select(a => new AlbumDto
            {
                Id = a.Id,
                Titulo = a.Titulo,
                SesionId = a.SesionId
            });
        }

        public async Task<AlbumDto> GetByIdAsync(int id)
        {
            var model = await _context.Albums.FindAsync(id);
            if (model == null) return null;

            return new AlbumDto
            {
                Id = model.Id,
                Titulo = model.Titulo,
                SesionId = model.SesionId
            };
        }

        public async Task<AlbumDto> CreateAsync(AlbumDto dto)
        {
            var model = new AlbumModel
            {
                Titulo = dto.Titulo,
                SesionId = dto.SesionId
            };

            _context.Albums.Add(model);
            await _context.SaveChangesAsync();

            dto.Id = model.Id;
            return dto;
        }

        public async Task<AlbumDto> UpdateAsync(int id, AlbumDto dto)
        {
            var model = await _context.Albums.FindAsync(id);
            if (model == null) return null;

            model.Titulo = dto.Titulo;
            model.SesionId = dto.SesionId;

            await _context.SaveChangesAsync();
            return dto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var model = await _context.Albums.FindAsync(id);
            if (model == null) return false;

            _context.Albums.Remove(model);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
