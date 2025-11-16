using EstudioFotografia.Application.Contract;
using EstudioFotografia.Application.Core;
using EstudioFotografia.Application.Dtos;
using EstudioFotografia.Infrastructure.Context;
using EstudioFotografia.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudioFotografia.Application.Services
{
    public class EntregaService : BaseService, IEntregaService
    {
        private readonly EstudioContext _context;

        public EntregaService(EstudioContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<EntregaDto>> GetAllAsync()
        {
            var lista = await _context.Entregas.ToListAsync();

            return lista.Select(e => new EntregaDto
            {
                Id = e.Id,
                FechaEntrega = e.FechaEntrega,
                SesionId = e.SesionId
            });
        }

        public async Task<EntregaDto?> GetByIdAsync(int id)
        {
            var entrega = await _context.Entregas.FindAsync(id);

            if (entrega == null) return null;

            return new EntregaDto
            {
                Id = entrega.Id,
                FechaEntrega = entrega.FechaEntrega,
                SesionId = entrega.SesionId
            };
        }

        public async Task<EntregaDto> CreateAsync(EntregaDto dto)
        {
            var entrega = new EntregaModel
            {
                FechaEntrega = dto.FechaEntrega,
                SesionId = dto.SesionId
            };

            _context.Entregas.Add(entrega);
            await _context.SaveChangesAsync();

            dto.Id = entrega.Id;
            return dto;
        }

        public async Task<EntregaDto> UpdateAsync(int id, EntregaDto dto)
        {
            var entrega = await _context.Entregas.FindAsync(id);

            if (entrega == null)
                throw new Exception("Entrega no encontrada");

            entrega.FechaEntrega = dto.FechaEntrega;
            entrega.SesionId = dto.SesionId;

            await _context.SaveChangesAsync();

            dto.Id = entrega.Id;
            return dto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entrega = await _context.Entregas.FindAsync(id);

            if (entrega == null)
                return false;

            _context.Entregas.Remove(entrega);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
