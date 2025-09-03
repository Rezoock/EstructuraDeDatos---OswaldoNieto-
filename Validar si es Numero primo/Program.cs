using Validar_si_es_Numero_primo;

NumeroPrimo miNumero = new NumeroPrimo();
Console.WriteLine("Teclee el numero que desea verificar si es Primo ");
miNumero.Numero = double.Parse(Console.ReadLine());
bool Resultado = miNumero.CalcularNumeroPrimo() ;
Console.WriteLine("El numero " + ( Resultado ? "Si" : "No") + " es numero Primo" );
Console.ReadLine();