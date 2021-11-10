using System;

namespace DependencyInversionPrinciple.Classes
{
    public class SMS : IMensagemCelular
    {
        public void EnviarMensagem(IContato cliente, string mensagem)
        {
            Console.WriteLine($"SMS enviado para {cliente.Celular}: '{mensagem}'");
        }
    }
}
