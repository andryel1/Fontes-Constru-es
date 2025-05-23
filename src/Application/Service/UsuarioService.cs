using aplication.Interfaces.Service;

namespace Application.Service;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioService _usuarioService;

    public UsuarioService(IUsuarioService usuarioService)
    {
        _usuarioService = usuarioService;
    }
}
