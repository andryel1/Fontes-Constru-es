using Application.Interfaces.Service;
using Application.Interfaces.Repository; // Import necessário para o Repositório
using Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Service
{
    // CORRIGIDO: Injeta ITagRepository para evitar o ciclo de dependência.
    public class DescontoService(IDescontoRepository descontoRepository) : IDescontoService
    {
        private readonly IDescontoRepository _descontoRepository = descontoRepository;

        // Os métodos abaixo usam a dependência de Repositório (_descontoRepository)
        // para buscar/salvar dados.

        public Task<IEnumerable<DescontoDto>> ObterDescontosAtivos()
        {
            throw new NotImplementedException("O método ObterDescontosAtivos deve ser implementado usando a dependência de Repositório.");
        }

        public Task<IEnumerable<DescontoDto>> ObterDescontosInativos()
        {
            throw new NotImplementedException("O método ObterDescontosInativos deve ser implementado usando a dependência de Repositório.");
        }

        public Task<IEnumerable<DescontoDto>> ObterDescontosExpirados()
        {
            throw new NotImplementedException("O método ObterDescontosExpirados deve ser implementado usando a dependência de Repositório.");
        }

        public Task<DescontoDto> Adicionar(DescontoDto dto)
        {
            throw new NotImplementedException("O método Adicionar deve ser implementado usando a dependência de Repositório.");
        }

        public Task<DescontoDto> Atualizar(DescontoDto dto)
        {
            throw new NotImplementedException("O método Atualizar deve ser implementado usando a dependência de Repositório.");
        }
  
        public Task<DescontoDto> ObterPorId(int id)
        {
            throw new NotImplementedException("O método ObterPorId deve ser implementado usando a dependência de Repositório.");
        }

        public Task<List<DescontoDto>> ObterTodos()
        {
            throw new NotImplementedException("O método ObterTodos deve ser implementado usando a dependência de Repositório.");
        }

        public Task<bool> Deletar(int id)
        {
            throw new NotImplementedException("O método Deletar deve ser implementado usando a dependência de Repositório.");
        }
    }
}
