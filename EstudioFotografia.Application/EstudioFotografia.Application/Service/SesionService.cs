using EstudioFotografia.Application.Contract;
using EstudioFotografia.Application.Dtos;
using EstudioFotografia.Application.Core;
using EstudioFotografia.Infrastructure.Context;
using EstudioFotografia.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudioFotografia.Application.Services
{
    public class SesionService : BaseService, ISesionService
    {
        private readonly EstudioContext _context;

        public SesionService(EstudioContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SesionDto>> GetAllAsync()
        {
            var sesiones = await _context.Sesiones.ToListAsync();

            return sesiones.Select(s => new SesionDto
            {
                Id = s.Id,
                Fecha = s.Fecha,
                ClienteId = s.ClienteId,
                PaqueteId = s.PaqueteId
            });
        }

        public async Task<SesionDto?> GetByIdAsync(int id)
        {
            var sesion = await _context.Sesiones.FindAsync(id);

            if (sesion == null)
                return null;

            return new SesionDto
            {
                Id = sesion.Id,
                Fecha = sesion.Fecha,
                ClienteId = sesion.ClienteId,
                PaqueteId = sesion.PaqueteId
            };
        }

        public async Task<SesionDto> CreateAsync(SesionDto dto)
        {
            var sesion = new SesionModel
            {
                Fecha = dto.Fecha,
                ClienteId = dto.ClienteId,
                PaqueteId = dto.PaqueteId
            };

            _context.Sesiones.Add(sesion);
            await _context.SaveChangesAsync();

            dto.Id = sesion.Id;
            return dto;
        }

        public async Task<SesionDto> UpdateAsync(int id, SesionDto dto)
        {
            var sesion = await _context.Sesiones.FindAsync(id);

            if (sesion == null)
                return null;

            sesion.Fecha = dto.Fecha;
            sesion.ClienteId = dto.ClienteId;
            sesion.PaqueteId = dto.PaqueteId;

            await _context.SaveChangesAsync();

            return dto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var sesion = await _context.Sesiones.FindAsync(id);

            if (sesion == null)
                return false;

            _context.Sesiones.Remove(sesion);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
