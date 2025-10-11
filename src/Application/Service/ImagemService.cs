using Application.Dtos;
using Application.Interfaces.Service;
using Application.Interfaces.Repository; // Import necessário para o Repositório
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Service
{
    // CORRIGIDO: Injeta IImagemRepository para evitar o ciclo de dependência.
    public class ImagemService(IImagemRepository imagemRepository) : IImagemService
    {
        private readonly IImagemRepository _imagemRepository = imagemRepository;

        // Os métodos abaixo usam a dependência de Repositório (_imagemRepository)
        // para buscar/salvar dados.

        public Task<ImagemDto> Adicionar(ImagemDto entity)
        {
            throw new NotImplementedException("O método Adicionar deve ser implementado usando a dependência de Repositório.");
        }

        public Task<ImagemDto> Atualizar(ImagemDto entity)
        {
            throw new NotImplementedException("O método Atualizar deve ser implementado usando a dependência de Repositório.");
        }

        public Task<bool> Deletar(int id)
        {
            throw new NotImplementedException("O método Deletar deve ser implementado usando a dependência de Repositório.");
        }

        public Task<ImagemDto> ObterImagemPorId(Guid id)
        {
            throw new NotImplementedException("O método ObterImagemPorId deve ser implementado usando a dependência de Repositório.");
        }

        public Task<ImagemDto> ObterImagemPorIdProduto(Guid idProduto)
        {
            throw new NotImplementedException("O método ObterImagemPorIdProduto deve ser implementado usando a dependência de Repositório.");
        }

        public Task<IEnumerable<ImagemDto>> ObterImagensPorIdProduto(Guid idProduto)
        {
            throw new NotImplementedException("O método ObterImagensPorIdProduto deve ser implementado usando a dependência de Repositório.");
        }

        public Task<ImagemDto> ObterPorId(int id)
        {
            throw new NotImplementedException("O método ObterPorId deve ser implementado usando a dependência de Repositório.");
        }

        public Task<List<ImagemDto>> ObterTodos()
        {
            throw new NotImplementedException("O método ObterTodos deve ser implementado usando a dependência de Repositório.");
        }
    }
}
