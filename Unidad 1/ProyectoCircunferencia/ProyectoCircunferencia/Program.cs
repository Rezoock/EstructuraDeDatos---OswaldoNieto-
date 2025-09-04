// See https://aka.ms/new-console-template for more informationMI
using ProyectoCircunferencia;

Circunferencia miCircunferencia = new Circunferencia();

Console.WriteLine("Ingrese el radio de la circunferencia");
miCircunferencia.Radio = double.Parse(Console.ReadLine());  
Console.WriteLine("El area de la circunferencia es: " + miCircunferencia.CalcularCircunferencia());
Console.ReadKey();
