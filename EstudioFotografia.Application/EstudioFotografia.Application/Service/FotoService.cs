using EstudioFotografia.Application.Contract;
using EstudioFotografia.Application.Core;
using EstudioFotografia.Application.Dtos;
using EstudioFotografia.Infrastructure.Context;
using EstudioFotografia.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudioFotografia.Application.Services
{
    public class FotoService : BaseService, IFotoService
    {
        private readonly EstudioContext _context;

        public FotoService(EstudioContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FotoDto>> GetAllAsync()
        {
            var fotos = await _context.Fotos.ToListAsync();

            return fotos.Select(f => new FotoDto
            {
                Id = f.Id,
                Ruta = f.Ruta,
                AlbumId = f.AlbumId
            });
        }

        public async Task<FotoDto?> GetByIdAsync(int id)
        {
            var foto = await _context.Fotos.FindAsync(id);

            if (foto == null)
                return null;

            return new FotoDto
            {
                Id = foto.Id,
                Ruta = foto.Ruta,
                AlbumId = foto.AlbumId
            };
        }

        public async Task<FotoDto> CreateAsync(FotoDto dto)
        {
            var foto = new FotoModel
            {
                Ruta = dto.Ruta,
                AlbumId = dto.AlbumId
            };

            _context.Fotos.Add(foto);
            await _context.SaveChangesAsync();

            dto.Id = foto.Id;
            return dto;
        }

        public async Task<FotoDto> UpdateAsync(int id, FotoDto dto)
        {
            var foto = await _context.Fotos.FindAsync(id);

            if (foto == null)
                throw new Exception("Foto no encontrada");

            foto.Ruta = dto.Ruta;
            foto.AlbumId = dto.AlbumId;

            await _context.SaveChangesAsync();

            return dto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var foto = await _context.Fotos.FindAsync(id);

            if (foto == null)
                return false;

            _context.Fotos.Remove(foto);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
