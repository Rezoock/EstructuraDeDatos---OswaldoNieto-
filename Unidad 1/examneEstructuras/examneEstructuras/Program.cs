using System;
using System.Collections.Generic;

namespace ListaDeUsuarios
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            
            var usuarios = new List<string>();

            Console.WriteLine("Introduce nombres de usuario. Escribe 'fin' para terminar.");

            while (true)
            {
                Console.Write("Nuevo usuario: ");

             
                string entrada = Console.ReadLine();

                if (entrada.ToLower() == "fin")
                {
                    break; 
                }

               
                usuarios.Add(entrada);
            }

            
            Console.WriteLine("Lista completa de usuarios");

           
            foreach (var usuario in usuarios)
            {
                Console.WriteLine(usuario);
            }
        }
    }
}