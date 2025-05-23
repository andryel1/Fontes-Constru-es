using Application.Interfaces.Services;

namespace Application.Service
{
    public class ImagemService : IImagemService
    {
        private readonly IImagemService _imagemService;

        public ImagemService(IImagemService imagemService)
        {
            _imagemService = imagemService;
        }
    }
}
