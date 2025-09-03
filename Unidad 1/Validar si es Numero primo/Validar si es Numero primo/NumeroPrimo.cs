using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validar_si_es_Numero_primo
{
    internal class NumeroPrimo
    {
        private double _Numero;
       public double Numero
        {
            get { return _Numero; }
            set { _Numero = value; }

        }
        public bool CalcularNumeroPrimo()
        {
            if (this.Numero < 2)
            {
                return false;
            }
            if (this.Numero == 2)
            {
                return true;
            }
            if (this.Numero % 2 == 0)
            {
                return false;
            }
            return true;
        }
        
    }
}
