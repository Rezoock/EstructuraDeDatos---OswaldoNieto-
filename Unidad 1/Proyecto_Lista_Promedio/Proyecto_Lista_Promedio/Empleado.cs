using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Lista_Promedio
{
    internal class Empleado
    {
        private string _Nombre;
        private double _Salario;
        private List<Empleado> _ListaEmpleados = new List<Empleado>();
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public double Salario
        {
            get { return _Salario; }
            set { _Salario = value; }
        }
        public List<Empleado> ListaEmpleados
        {
            get { return _ListaEmpleados; }
        }
        public int IdentificarNumeroEmpleados()
        {
            return _ListaEmpleados.Count;
        }
        public double SumarSueldoEmpleados()
        {
            double dblSumaSueldos = 0.0;
            foreach (Empleado miEmpleado in _ListaEmpleados)
            {
                dblSumaSueldos += miEmpleado.Salario;
            }
            return dblSumaSueldos;
        }
        public double PromedioDeSueldoDeEmpleados()
        {
            return SumarSueldoEmpleados() / IdentificarNumeroEmpleados();
        }
        public void InsertarEmpleado(Empleado unEmpleado)
        {
            _ListaEmpleados.Add(unEmpleado);
        }
    }
}
