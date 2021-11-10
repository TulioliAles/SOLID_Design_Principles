using OpenClosedPrinciple.Model;

namespace OpenClosedPrinciple.Classes
{
    public interface ICalculaSalario
    {
        decimal CalcularSalario(IFuncionario func);
    }
}