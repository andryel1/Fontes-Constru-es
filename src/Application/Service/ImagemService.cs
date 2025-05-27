using Application.Dtos;
using Application.Interfaces.Service;

namespace Application.Service
{
    public class ImagemService(IImagemService imagemService) : IImagemService
    {
        private readonly IImagemService _imagemService = imagemService;

        public Task<ImagemDto> Adicionar(ImagemDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<ImagemDto> Atualizar(ImagemDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ImagemDto> ObterImagemPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ImagemDto> ObterImagemPorIdProduto(Guid idProduto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ImagemDto>> ObterImagensPorIdProduto(Guid idProduto)
        {
            throw new NotImplementedException();
        }

        public Task<ImagemDto> ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ImagemDto>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
