using OpenClosedPrinciple.Model;

namespace OpenClosedPrinciple.Classes
{
    public class CalculaSalario : ICalculaSalario
    {
        public decimal CalcularSalario(IFuncionario func)
        {
            decimal salarioCalculado = func.HorasTrabalhadasMes * (func.Salario / func.CargaHorariaMes);
            return salarioCalculado;
        }
    }
}
