//4.Suma acumulada con variable global
//	Declara una variable global sumaTotal. Cada vez que el usuario ingrese un número (en un método), se debe sumar al acumulado y mostrar el total actualizado.

using System;

class Program
{
    static double sumaTotal = 0; // variable global

    static void Main(string[] args)
    {
        Console.WriteLine("Programa de suma acumulada.");
        Console.WriteLine("Escriba 'salir' para terminar.\n");

        while (true)
        {
            Console.Write("Ingrese un número: ");
            string entrada = Console.ReadLine().Trim().ToLower();

            if (entrada == "salir") break;

            if (double.TryParse(entrada, out double numero))
            {
                sumaTotal += numero;
                Console.WriteLine($"Suma acumulada: {sumaTotal}");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Intente de nuevo.");
            }
        }
    }
}