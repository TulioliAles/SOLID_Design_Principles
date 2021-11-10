using SingleResponsibilityPrinciple.Model;

namespace SingleResponsibilityPrinciple.Classes
{
    public static class CalculaSalario
    {
        public static decimal CalcularSalario(Funcionario funcionario)
        {
            return funcionario.HorasTrabalhadasMes * (funcionario.Salario / funcionario.CargaHorariaMes);
        }
    }
}
