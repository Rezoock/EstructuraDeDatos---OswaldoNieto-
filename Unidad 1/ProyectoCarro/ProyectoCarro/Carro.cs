using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCarro
{
    internal class Carro
    {
        private string _Marca;
        private string _Modelo;
        private double _Velocidad;
        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value; }
        }   
        public string Modelo
        {
            get { return _Modelo; }
            set { _Modelo = value; }
        }
        public double Velocidad
        {
            get { return _Velocidad; }
            set { _Velocidad = value; }
        }
        public string Acelerar()
        {
           return "El " + Modelo + " esta acelerando";
        }
        public string Frenar()
        {
            return "El " + Modelo + " esta frenando";
        }
        public override string ToString()
        {
            return " Marca: " + Marca + " Modelo: " + Modelo + " Velocidad:" + Velocidad + " km/h";
        }
    }
}
