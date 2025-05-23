using application.Interfaces.Services;

namespace Application.Service;

    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaService(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }
    }
