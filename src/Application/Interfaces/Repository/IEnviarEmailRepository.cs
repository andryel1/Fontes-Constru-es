namespace Application.Interfaces.Repository;
    public interface IEnviarEmailRepository
    {
        Task EnviarEmail(string email, string assunto, string mensagem);
    }
