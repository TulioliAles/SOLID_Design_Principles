using OpenClosedPrinciple.Model;

namespace OpenClosedPrinciple.Classes
{
    public class CalculaSalarioJunior : ICalculaSalario
    {
        public decimal CalcularSalario(IFuncionario func)
        {
            decimal salarioCalculado = func.HorasTrabalhadasMes * (func.Salario / func.CargaHorariaMes);
            salarioCalculado *= 1.05M;
            return salarioCalculado;
        }
    }
}
