using Application.Interfaces.Service;

namespace Application.Service;

public class UsuarioService(IUsuarioService usuarioService) : IUsuarioService
{
    private readonly IUsuarioService _usuarioService = usuarioService;
}
