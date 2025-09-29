using System;
using System.Collections.Generic;
using System.Threading; // Necesario para usar Thread.Sleep()

namespace SimuladorImpresora
{
    class Program
    {
        static void Main(string[] args)
        {

            var colaDeImpresion = new Queue<string>();

            Console.WriteLine("La impresora está lista Enviando documentos a la cola");

            
            colaDeImpresion.Enqueue("tarea.pdf");
            Console.WriteLine("- 'tarea.pdf' ha entrado a la cola.");
            Thread.Sleep(500); 

            colaDeImpresion.Enqueue("tareas.docs");
            Console.WriteLine("- 'tareas.docs' ha entrado a la cola.");
            Thread.Sleep(500);

          
            colaDeImpresion.Enqueue("foto_vacaciones.jpg");
            Console.WriteLine("- 'foto_vacaciones.jpg' ha entrado a la cola.");
            Thread.Sleep(500);

            Console.WriteLine($"\nHay {colaDeImpresion.Count} documentos en espera. Comenzando a imprimir...");
            

         
            while (colaDeImpresion.Count > 0)
            {
               
                string documentoActual = colaDeImpresion.Dequeue();

                Console.WriteLine($"\nImprimiendo: '{documentoActual}'");
                Thread.Sleep(2000); 

                Console.WriteLine($"-> '{documentoActual}' impreso correctamente.");
                Console.WriteLine($"   Documentos restantes en la cola: {colaDeImpresion.Count}");
            }

           
           
            Console.WriteLine("Todos los documentos han sido impresos. La cola está vacía.");
        }
    }
}