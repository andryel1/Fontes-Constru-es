using Application.Dtos;
using Application.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Ecommerce.Domain.Entities;
using System.Security.Cryptography;
using System.Text;

namespace Infrastructure.Repositories;

public class AuthRepository : IAuthRepository
{
    private readonly Context _context;

    public AuthRepository(Context context)
    {
        _context = context;
    }

    public async Task<bool> LoginAsync(LoginDto dto)
    {
        if (string.IsNullOrEmpty(dto.Password))
            return false;
            
        var hashedPassword = HashPassword(dto.Password);
        
        var usuario = await _context.Usuarios
            .Include(u => u.Cliente)
            .Include(u => u.Administrador)
            .FirstOrDefaultAsync(u => u.Email == dto.Email && u.Password == hashedPassword);

        return usuario != null;
    }

    public async Task<bool> RegisterAsync(RegistroDto dto)
    {
        // Verificar se o email já existe
        var existingUser = await _context.Usuarios
            .FirstOrDefaultAsync(u => u.Email == dto.Email);

        if (existingUser != null)
            return false;

        if (string.IsNullOrEmpty(dto.Password) || dto.Password != dto.ConfirmarPassword)
            return false;

        var hashedPassword = HashPassword(dto.Password);

        var novoUsuario = new Usuario
        {
            UserName = dto.Nome,
            Email = dto.Email,
            Password = hashedPassword,
            DataNascimento = DateTime.Now 
        };

        _context.Usuarios.Add(novoUsuario);
        var result = await _context.SaveChangesAsync();

        return result > 0;
    }

    public async Task<Usuario?> GetUserByEmailAsync(string email)
    {
        return await _context.Usuarios
            .Include(u => u.Cliente)
            .Include(u => u.Administrador)
            .FirstOrDefaultAsync(u => u.Email == email);
    }

    private string HashPassword(string password)
    {
        using var sha256 = SHA256.Create();
        var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        return Convert.ToBase64String(hashedBytes);
    }
} 