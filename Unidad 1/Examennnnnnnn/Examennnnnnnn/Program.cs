using System;
using System.Collections.Generic;

public class SimuladorNavegacion
{
    public static void Main(string[] args)
    {
        // 1. Se crea la pila para el historial de navegación.
        var historial = new Stack<string>();

        // 2. El usuario visita 3 páginas web. Se 'apilan' (Push).
        Console.WriteLine("Navegando a páginas...");

        historial.Push("google.com");
        Console.WriteLine("- Entrando a google.com");

        historial.Push("wikipedia.org");
        Console.WriteLine("- Entrando a wikipedia.org");

        historial.Push("openai.com");
        Console.WriteLine("- Entrando a openai.com");

        Console.WriteLine("\nLa página actual es: openai.com");
        Console.WriteLine(new string('-', 30));

        // 3. El usuario presiona el botón "volver" una vez. Se 'desapila' (Pop).
        Console.WriteLine("\n... Presionando el botón 'Atrás' ...\n");
        string paginaAnterior = historial.Pop(); // Se quita "openai.com" de la pila
        Console.WriteLine($"Has salido de: {paginaAnterior}");

        Console.WriteLine(new string('-', 30));

        // 4. Se muestra la pila actual.
        // Un 'foreach' en un Stack recorre desde el tope hacia abajo.
        Console.WriteLine("\nPila de navegación actual:");
        foreach (var pagina in historial)
        {
            Console.WriteLine($"- {pagina}");
        }

        // 5. Se muestra la página que ahora está en el tope de la pila.
        // .Peek() mira el elemento del tope sin quitarlo.
        Console.WriteLine("\nLa página actual (tope de la pila) es:");
        Console.WriteLine($"> {historial.Peek()}");
    }
}