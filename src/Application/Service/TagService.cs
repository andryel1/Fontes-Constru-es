using Application.Interfaces.Services;

namespace Application.service;

    public class TagService : ITagService
    {
        private readonly ITagService _tagService;

        public TagService(ITagService tagService)
        {
            _tagService = tagService;
        }
    }
