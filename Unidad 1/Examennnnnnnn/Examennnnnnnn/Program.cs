using System;
using System.Collections.Generic;

public class SimuladorNavegacion
{
    public static void Main(string[] args)
    {

        var historial = new Stack<string>();


        Console.WriteLine("Navegando a páginas...");

        historial.Push("google.com");
        Console.WriteLine("- Entrando a google.com");

        historial.Push("wikipedia.org");
        Console.WriteLine("- Entrando a wikipedia.org");

        historial.Push("openai.com");
        Console.WriteLine("- Entrando  openai.com");

        Console.WriteLine("\nLa página actual es: openai.com");
        Console.WriteLine(new string('-', 30));

        Console.WriteLine("\n... Presionando el botón 'Atrás' ...\n");
        string paginaAnterior = historial.Pop(); 
        Console.WriteLine($"Has salido de: {paginaAnterior}");

        Console.WriteLine(new string('-', 30));

        Console.WriteLine("\nPila de navegación actual:");
        foreach (var pagina in historial)
        {
            Console.WriteLine($"- {pagina}");
        }

        Console.WriteLine("\nLa página actual (tope de la pila) es:");
        Console.WriteLine($"> {historial.Peek()}");
    }
}