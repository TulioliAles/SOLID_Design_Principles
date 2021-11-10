namespace LiskovSubstitutionPrinciple.Classes
{
    public class Retangulo : Figura
    {
        private double _altura;
        private double _largura;

        public void SetLargura(double largura)
        {
            _largura = largura;
        }

        public void SetAltura(double altura)
        {
            _altura = altura;
        }

        public override double Area()
        {
            return _largura * _altura;
        }
    }
}
