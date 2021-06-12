using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractas
{
    class Rectangulo : Figura
    {

        public Rectangulo(double _base, double _altura)
        {
            Base = _base;
            Altura = _altura;
        }
        public override double CalcularArea()
        {
            return Base * Altura;
        }

        public double CalcularPerimetro()
        {
            return (Base * 2) + (Altura * 2);
        }
    }
}
