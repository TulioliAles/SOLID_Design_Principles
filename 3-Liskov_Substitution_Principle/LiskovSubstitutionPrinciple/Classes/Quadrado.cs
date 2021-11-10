using System;

namespace LiskovSubstitutionPrinciple.Classes
{
    public class Quadrado : Figura
    {
        private double _tamanho;

        public void SetTamanho(double tamanho)
        {
            _tamanho = tamanho;
        }
        public override double Area()
        {
            return Math.Pow(_tamanho, 2);
        }
    }
}
