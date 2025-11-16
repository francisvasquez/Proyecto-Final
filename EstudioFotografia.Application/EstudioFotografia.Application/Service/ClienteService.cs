using EstudioFotografia.Application.Contract;
using EstudioFotografia.Application.Core;
using EstudioFotografia.Application.Dtos;
using EstudioFotografia.Infrastructure.Context;
using EstudioFotografia.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace EstudioFotografia.Application.Services
{
    public class ClienteService : BaseService, IClienteService
    {
        private readonly EstudioContext _context;

        public ClienteService(EstudioContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ClienteDto>> GetAllAsync()
        {
            var lista = await _context.Clientes.ToListAsync();

            return lista.Select(c => new ClienteDto
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Apellido = c.Apellido,
                Telefono = c.Telefono,
                Email = c.Email
            });
        }

        public async Task<ClienteDto> GetByIdAsync(int id)
        {
            var c = await _context.Clientes.FindAsync(id);
            if (c == null) return null;

            return new ClienteDto
            {
                Id = c.Id,
                Nombre = c.Nombre,
                Apellido = c.Apellido,
                Telefono = c.Telefono,
                Email = c.Email
            };
        }

        public async Task<ClienteDto> CreateAsync(ClienteDto dto)
        {
            var cliente = new ClienteModel
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                Telefono = dto.Telefono,
                Email = dto.Email
            };

            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();

            dto.Id = cliente.Id;
            return dto;
        }

        public async Task<ClienteDto> UpdateAsync(int id, ClienteDto dto)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null) return null;

            cliente.Nombre = dto.Nombre;
            cliente.Apellido = dto.Apellido;
            cliente.Telefono = dto.Telefono;
            cliente.Email = dto.Email;

            await _context.SaveChangesAsync();

            dto.Id = cliente.Id;
            return dto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null) return false;

            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
