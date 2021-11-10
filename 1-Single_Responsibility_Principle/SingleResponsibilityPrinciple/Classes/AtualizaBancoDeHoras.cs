using SingleResponsibilityPrinciple.Model;
using System;

namespace SingleResponsibilityPrinciple.Classes
{
    public static class AtualizaBancoDeHoras
    {
        public static void AtualizarBancoDeHoras(Funcionario funcionario)
        {
            Console.WriteLine($"Banco de horas: {funcionario.Nome} trabalhou {funcionario.HorasTrabalhadasMes} horas do mês atual.");
        }
    }
}
