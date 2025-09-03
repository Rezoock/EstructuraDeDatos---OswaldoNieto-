// See https://aka.ms/new-console-template for more information
using juego_AdivinaNumero;

JuegoAdivina miJuego = new JuegoAdivina();
Console.WriteLine("Teclee un numero del 1 - 50 ");
miJuego.Numero = int.Parse(Console.ReadLine());
bool Resultado = miJuego.CalcularNumIgual();
Console.WriteLine("El numero " + (Resultado ? "Si" : "No" ) + " es igual que el de la maquina");

Console.ReadLine();
Console.WriteLine( "El numero de la maquina es " + miJuego.GenerarNumAleatorio());
Console.ReadLine() ;
