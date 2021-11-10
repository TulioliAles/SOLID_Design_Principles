namespace DependencyInversionPrinciple.Classes
{
    public interface IEmail
    {
        void EnviarEmail(IContato cliente, string assunto, string mensagem);
    }
}