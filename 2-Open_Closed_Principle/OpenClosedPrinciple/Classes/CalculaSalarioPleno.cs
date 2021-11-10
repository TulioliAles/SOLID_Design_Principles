using OpenClosedPrinciple.Model;

namespace OpenClosedPrinciple.Classes
{
    public class CalculaSalarioPleno : ICalculaSalario
    {
        public decimal CalcularSalario(IFuncionario func)
        {
            decimal salarioCalculado = func.HorasTrabalhadasMes * (func.Salario / func.CargaHorariaMes);
            salarioCalculado *= 1.1M;
            return salarioCalculado;
        }
    }
}
