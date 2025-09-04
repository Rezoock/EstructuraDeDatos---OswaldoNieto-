using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradosCF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura temperatura1 = new Temperatura();

            Console.WriteLine("Teclee los grados Centigrados");
            temperatura1.GradosC = double.Parse(Console.ReadLine());

            Console.WriteLine("La Temperatura en grados Farhenheit es: " + temperatura1.CalcularCelsisus().ToString());
            Console.ReadLine(); 

        }
    }
}
