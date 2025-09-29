using System;
using System.Collections.Generic;
using System.Linq; 

public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
}

public class GestorUsuarios
{
   
    private Dictionary<int, Usuario> usuariosPorId = new Dictionary<int, Usuario>();

    public void AgregarUsuario(Usuario usuario)
    {
        usuariosPorId[usuario.Id] = usuario;
    }

  
    public Usuario BuscarPorId(int id)
    {
        usuariosPorId.TryGetValue(id, out var usuario);
        return usuario;
    }
}




public class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
}

public class CatalogoProductos
{
    private List<Producto> productos = new List<Producto>();

    public void AgregarProducto(Producto producto)
    {
        productos.Add(producto);
    }

    public List<Producto> ObtenerProductosOrdenadosPorPrecio()
    {
     
        return productos.OrderBy(p => p.Precio).ToList();
    }
}



public class EstadisticasEnTiempoReal
{
    private long _visitasPagina = 0;
    private decimal _ventasTotales = 0;

    public void RegistrarVisita()
    {
        _visitasPagina++;
    }

    public void RegistrarVenta(decimal monto)
    {
        _ventasTotales += monto;
    }

    public void MostrarEstadisticas()
    {
        Console.WriteLine($"Visitas totales: {_visitasPagina}");
        Console.WriteLine($"Ventas totales: ${_ventasTotales:N2}"); 
    }
}




public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("### 1. DEMO: Búsqueda Rápida de Usuarios ###");
        var gestor = new GestorUsuarios();
        gestor.AgregarUsuario(new Usuario { Id = 101, Nombre = "Ana" });
        gestor.AgregarUsuario(new Usuario { Id = 205, Nombre = "Pedro" });

        var usuarioEncontrado = gestor.BuscarPorId(205);
        Console.WriteLine($"Buscando usuario con ID 205...");
        Console.WriteLine($"Encontrado: {usuarioEncontrado.Nombre}\n");
        Console.WriteLine("-> Búsqueda casi instantánea gracias a la Tabla Hash (Dictionary).\n");

        Console.WriteLine(new string('-', 40));

        Console.WriteLine("\n### 2. DEMO: Ordenamiento Eficiente de Productos ###");
        var catalogo = new CatalogoProductos();
        catalogo.AgregarProducto(new Producto { Nombre = "Laptop", Precio = 1200.50m });
        catalogo.AgregarProducto(new Producto { Nombre = "Mouse", Precio = 25.00m });
        catalogo.AgregarProducto(new Producto { Nombre = "Teclado", Precio = 75.99m });

        var productosOrdenados = catalogo.ObtenerProductosOrdenadosPorPrecio();
        Console.WriteLine("Productos ordenados por precio (menor a mayor):");
        foreach (var producto in productosOrdenados)
        {
            Console.WriteLine($"- {producto.Nombre}: ${producto.Precio}");
        }
        Console.WriteLine("\n-> Ordenamiento eficiente usando un algoritmo O(n log n).\n");

        Console.WriteLine(new string('-', 40));

        Console.WriteLine("\n### 3. DEMO: Estadísticas en Tiempo Real ###");
        var stats = new EstadisticasEnTiempoReal();
        stats.RegistrarVisita();
        stats.RegistrarVenta(25.00m);
        stats.RegistrarVisita();
        stats.RegistrarVenta(1200.50m); 

        Console.WriteLine("Estadísticas actuales:");
        stats.MostrarEstadisticas();
        Console.WriteLine("\n-> Las estadísticas se actualizan en tiempo O(1), sin recalcular todo.");
    }
}