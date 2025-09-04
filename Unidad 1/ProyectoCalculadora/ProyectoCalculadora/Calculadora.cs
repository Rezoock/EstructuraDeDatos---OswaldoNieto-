using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCalculadora
{
    internal class Calculadora
    {
        private double _Numero1;
        private double _Numero2;
        public double Numero1
        {
            get { return _Numero1; }
            set { _Numero1 = value; }

        }
        public double Numero2
        {
            get { return _Numero2; }
            set { _Numero2 = value; }
        }
        public double CalcularSuma()
        {
            return _Numero1 + _Numero2;
        }
        public double CalcularResta()
        {
            return _Numero1 - _Numero2;
        }
        public double CalcularMultiplicacion()
        {
            return _Numero1 * _Numero2;
        }
        public double CalcularDivision()
        {
            if (_Numero2 == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero.");
            }
            return _Numero1 / _Numero2;
        }

    }
}
