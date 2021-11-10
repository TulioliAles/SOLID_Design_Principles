using OpenClosedPrinciple.Classes;
using OpenClosedPrinciple.Model;
using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    class Program
    {
        //Ação: "Nós devemos nos esforçar para escrever um código que não tenha que ser ALTERADO, toda vez que tenhamos uma mudança de requisito."

        //Regra SRP: Cada classe deve ter apenas uma responsabilidade bem como uma única razão para alteração.

        //Regra OCP: Objetos devem estar abertos para extensão mas, fechados para modificação.

        //Requisitos:
        //Funcionário Sênior deve receber 20% de bônus sobre o salário líquido.
        //Funcionário Pleno deve receber 10% de bônus sobre o salário líquido.

        static void Main(string[] args)
        {
            var funcionarios = new List<IFuncionario>();

            funcionarios.Add(new FuncionarioPleno { Nome = "Alessandro", Conta = "12345-6", Salario = 1000, CargaHorariaMes = 220, HorasTrabalhadasMes = 200 });
            funcionarios.Add(new FuncionarioSenior { Nome = "Maria", Conta = "75223-4", Salario = 1000, CargaHorariaMes = 220, HorasTrabalhadasMes = 200 });
            funcionarios.Add(new Funcionario { Nome = "Victor", Conta = "96335-0", Salario = 1000, CargaHorariaMes = 220, HorasTrabalhadasMes = 200 });

            foreach (IFuncionario func in funcionarios)
            {
                decimal salarioReceber = func.CalculaSalario.CalcularSalario(func);
                Console.WriteLine($"{func.Nome}: Salário bruto: {func.Salario:c2}, Salário liquido: {salarioReceber:c2}");
            }

            Console.ReadLine();
        }
    }
}
