using EstudioFotografia.Application.Contract;
using EstudioFotografia.Application.Core;
using EstudioFotografia.Application.Dtos;
using EstudioFotografia.Infrastructure.Context;
using EstudioFotografia.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudioFotografia.Application.Services
{
    public class PagoService : BaseService, IPagoService
    {
        private readonly EstudioContext _context;

        public PagoService(EstudioContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PagoDto>> GetAllAsync()
        {
            var lista = await _context.Pagos.ToListAsync();

            return lista.Select(p => new PagoDto
            {
                Id = p.Id,
                Monto = p.Monto,
                FechaPago = p.FechaPago,
                SesionId = p.SesionId
            });
        }

        public async Task<PagoDto?> GetByIdAsync(int id)
        {
            var pago = await _context.Pagos.FindAsync(id);

            if (pago == null)
                return null;

            return new PagoDto
            {
                Id = pago.Id,
                Monto = pago.Monto,
                FechaPago = pago.FechaPago,
                SesionId = pago.SesionId
            };
        }

        public async Task<PagoDto> CreateAsync(PagoDto dto)
        {
            var pago = new PagoModel
            {
                Monto = dto.Monto,
                FechaPago = dto.FechaPago,
                SesionId = dto.SesionId
            };

            _context.Pagos.Add(pago);
            await _context.SaveChangesAsync();

            dto.Id = pago.Id;
            return dto;
        }

        public async Task<PagoDto> UpdateAsync(int id, PagoDto dto)
        {
            var pago = await _context.Pagos.FindAsync(id);

            if (pago == null)
                return null;

            pago.Monto = dto.Monto;
            pago.FechaPago = dto.FechaPago;
            pago.SesionId = dto.SesionId;

            await _context.SaveChangesAsync();

            return dto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var pago = await _context.Pagos.FindAsync(id);

            if (pago == null)
                return false;

            _context.Pagos.Remove(pago);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
