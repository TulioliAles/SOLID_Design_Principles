using OpenClosedPrinciple.Classes;

namespace OpenClosedPrinciple.Model
{
    public class Funcionario : IFuncionario
    {
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public string Conta { get; set; }
        public int CargaHorariaMes { get; set; }
        public int HorasTrabalhadasMes { get; set; }
        public ICalculaSalario CalculaSalario { get; set; } = new CalculaSalario();
    }
}
