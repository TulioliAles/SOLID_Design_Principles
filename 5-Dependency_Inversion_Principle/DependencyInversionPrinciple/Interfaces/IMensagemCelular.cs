namespace DependencyInversionPrinciple.Classes
{
    public interface IMensagemCelular
    {
        void EnviarMensagem(IContato cliente, string mensagem);
    }
}