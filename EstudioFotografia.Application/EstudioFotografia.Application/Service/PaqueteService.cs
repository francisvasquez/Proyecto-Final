using EstudioFotografia.Application.Contract;
using EstudioFotografia.Application.Dtos;
using EstudioFotografia.Application.Core;
using EstudioFotografia.Infrastructure.Context;
using EstudioFotografia.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudioFotografia.Application.Services
{
    public class PaqueteService : BaseService, IPaqueteService
    {
        private readonly EstudioContext _context;

        public PaqueteService(EstudioContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PaqueteDto>> GetAllAsync()
        {
            var paquetes = await _context.Paquetes.ToListAsync();

            return paquetes.Select(x => new PaqueteDto
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Precio = x.Precio,
                CantidadFotos = x.CantidadFotos
            });
        }

        public async Task<PaqueteDto?> GetByIdAsync(int id)
        {
            var paquete = await _context.Paquetes.FindAsync(id);

            if (paquete == null)
                return null;

            return new PaqueteDto
            {
                Id = paquete.Id,
                Nombre = paquete.Nombre,
                Precio = paquete.Precio,
                CantidadFotos = paquete.CantidadFotos
            };
        }

        public async Task<PaqueteDto> CreateAsync(PaqueteDto dto)
        {
            var paquete = new PaqueteModel
            {
                Nombre = dto.Nombre,
                Precio = dto.Precio,
                CantidadFotos = dto.CantidadFotos
            };

            _context.Paquetes.Add(paquete);
            await _context.SaveChangesAsync();

            dto.Id = paquete.Id;
            return dto;
        }

        public async Task<PaqueteDto> UpdateAsync(int id, PaqueteDto dto)
        {
            var paquete = await _context.Paquetes.FindAsync(id);

            if (paquete == null)
                return null;

            paquete.Nombre = dto.Nombre;
            paquete.Precio = dto.Precio;
            paquete.CantidadFotos = dto.CantidadFotos;

            await _context.SaveChangesAsync();

            return dto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var paquete = await _context.Paquetes.FindAsync(id);

            if (paquete == null)
                return false;

            _context.Paquetes.Remove(paquete);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
