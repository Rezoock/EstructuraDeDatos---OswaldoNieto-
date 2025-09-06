using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLibro
{
    internal class Libro
    {
        private string _Titulo;
        private string _Autor;
       public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }

        }
        public string Autor
        {
            get { return _Autor; }
            set { _Autor = value; }

        }
        public override string ToString()
        {
            return "El libro con el nombre: " + Titulo + " su autor es : " + Autor ;
        }
    }
}
