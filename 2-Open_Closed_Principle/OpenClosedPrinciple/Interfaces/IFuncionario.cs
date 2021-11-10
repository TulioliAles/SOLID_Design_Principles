using OpenClosedPrinciple.Classes;

namespace OpenClosedPrinciple.Model
{
    public interface IFuncionario
    {
        int CargaHorariaMes { get; set; }
        string Conta { get; set; }
        int HorasTrabalhadasMes { get; set; }
        string Nome { get; set; }
        decimal Salario { get; set; }
        ICalculaSalario CalculaSalario { get; set; }
    }
}