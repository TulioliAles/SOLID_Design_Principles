using OpenClosedPrinciple.Model;

namespace OpenClosedPrinciple.Classes
{
    public class FuncionarioJunior : IFuncionario
    {
        public int CargaHorariaMes { get; set; }
        public string Conta { get; set; }
        public int HorasTrabalhadasMes { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public ICalculaSalario CalculaSalario { get; set; } = new CalculaSalarioJunior();
    }
}
