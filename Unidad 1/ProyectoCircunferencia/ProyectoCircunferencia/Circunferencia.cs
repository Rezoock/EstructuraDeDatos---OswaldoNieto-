using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCircunferencia
{
    internal class Circunferencia
    {
        private double dblRadio;
        public double Radio
        {
            get { return dblRadio; }
            set { dblRadio = value; }
        }
       
        public double CalcularCircunferencia()
        {
            return (Math.PI * 2)* dblRadio ;
        }
    }
}
