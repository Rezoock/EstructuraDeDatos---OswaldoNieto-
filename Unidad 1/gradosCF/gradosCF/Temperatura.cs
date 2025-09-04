using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradosCF
{
    internal class Temperatura
    {
        private double _dblGradosC;

        public double GradosC
        { 
            set { _dblGradosC = value; }

        }

        public double CalcularCelsisus()
        {
            return (_dblGradosC * 9/5 ) + 32 ;
        }
    }
}
