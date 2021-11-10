using OpenClosedPrinciple.Model;

namespace OpenClosedPrinciple.Classes
{
    public class CalculaSalarioSenior : ICalculaSalario
    {
        public decimal CalcularSalario(IFuncionario func)
        {
            decimal salarioCalculado = func.HorasTrabalhadasMes * (func.Salario / func.CargaHorariaMes);
            salarioCalculado *= 1.2M;
            return salarioCalculado;
        }
    }
}
