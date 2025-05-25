using Application.Interfaces.Service;
using Application.Dtos;
using MailKit;
using MimeKit;
using Application.Interfaces.Repository;

namespace Application.Service
{
    public class EnviarEmailService(IEnviarEmailRepository emailRepository) : IEnviarEmailService
    {
        private readonly IEnviarEmailRepository _emailRepository = emailRepository;

        public async Task<bool> EnviarEmail(EnviarEmailDto emailDto)
        {
            try
            {
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(emailDto.Nome));
                email.To.Add(MailboxAddress.Parse(emailDto.Email));
                // Add subject and body if needed
                email.Subject = emailDto.Assunto;
                email.Body = new TextPart("plain") { Text = emailDto.Mensagem };

                if (emailDto.Email is null || emailDto.Assunto is null || emailDto.Mensagem is null)
                    return false;

                await _emailRepository.EnviarEmail(emailDto.Email, emailDto.Assunto, emailDto.Mensagem);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task EnviarEmail(string de, string para, string mensagem)
        {
            // Implement the method or delegate to repository
            await _emailRepository.EnviarEmail(de, para, mensagem);
        }
    }
}
