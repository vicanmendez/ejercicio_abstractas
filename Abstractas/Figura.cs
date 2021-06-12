using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractas
{
    abstract class Figura
    {
        private double _base;
        private double _altura;
        private double lado;

     
        protected double Base { get => _base; set => _base = value; }
        protected double Altura { get => _altura; set => _altura = value; }
        protected double Lado { get => lado; set => lado = value; }

        public abstract double CalcularArea();

        public virtual double CalcularPerimetro()
        {
            double perimetro = 0;

            return perimetro;
        }
    }
}
