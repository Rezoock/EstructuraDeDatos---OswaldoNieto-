using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego_AdivinaNumero
{
    internal class JuegoAdivina
    {
        private int _Numero;
        public int Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }
        public bool CalcularNumIgual()
        {
            int NumAleatorio = GenerarNumAleatorio();


            if (NumAleatorio == this.Numero)
            {
                return true;
            }
            return false;
        }
        public int GenerarNumAleatorio()
        {
            Random aleatorio = new Random();
            int NumAleatorio = aleatorio.Next(0, 50);
            return NumAleatorio;
        }
    }
}
