using Application.Dtos;
using Application.Interfaces.Service;
using Application.Interfaces.Repository; 


namespace Application.Service
{

    public class TagService(ITagRepository tagRepository) : ITagService
    {
        private readonly ITagRepository _tagRepository = tagRepository;


        public Task<TagDto> Adicionar(TagDto dto)
        {
            throw new NotImplementedException("O método Adicionar deve ser implementado usando a dependência de Repositório.");
        }

        public Task<TagDto> Atualizar(TagDto dto)
        {
            // Implementação real deve incluir mapeamento de DTO para Entity e chamada a _tagRepository.Atualizar()
            throw new NotImplementedException("O método Atualizar deve ser implementado usando a dependência de Repositório.");
        }
  
        public Task<bool> Deletar(int id)
        {
            // Implementação real deve chamar _tagRepository.Deletar(id)
            throw new NotImplementedException("O método Deletar deve ser implementado usando a dependência de Repositório.");
        }
        
        public Task<TagDto> ObterPorId(int id)
        {
            // Implementação real deve chamar _tagRepository.ObterPorId(id) e mapear para DTO.
            throw new NotImplementedException("O método ObterPorId deve ser implementado usando a dependência de Repositório.");
        }

        public Task<List<TagDto>> ObterTodos()
        {
            // Implementação real deve chamar _tagRepository.ObterTodos() e mapear para List<TagDto>.
            throw new NotImplementedException("O método ObterTodos deve ser implementado usando a dependência de Repositório.");
        }
    }
}
