using SingleResponsibilityPrinciple.Classes;
using SingleResponsibilityPrinciple.Model;
using System;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario { Nome = "Alessandro", Conta = "12345-6", Salario = 10000, CargaHorariaMes = 220, HorasTrabalhadasMes = 200 };

            decimal salarioReceber = CalculaSalario.CalcularSalario(funcionario);

            Console.WriteLine($"Salário bruto: {funcionario.Salario:c2}, Salário liquido: {salarioReceber:c2}");

            ProcessaPagamento.ProcessarPagamento(funcionario, salarioReceber);

            AtualizaBancoDeHoras.AtualizarBancoDeHoras(funcionario);

            Console.ReadLine();
        }
    }
}
