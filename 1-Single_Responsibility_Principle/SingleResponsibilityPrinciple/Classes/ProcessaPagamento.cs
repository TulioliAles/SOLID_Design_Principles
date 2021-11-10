using SingleResponsibilityPrinciple.Model;
using System;

namespace SingleResponsibilityPrinciple.Classes
{
    public static class ProcessaPagamento
    {
        public static void ProcessarPagamento(Funcionario funcionario, decimal salarioReceber)
        {
            Console.WriteLine($"Tranferências de fundos realizada: {funcionario.Nome}|{funcionario.Conta}|{salarioReceber:c2}");
        }
    }
}
