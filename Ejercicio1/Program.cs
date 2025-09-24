//1.Contador de accesos global
//	Declara una variable global que almacene el número de veces que se ha ejecutado un método. Cada vez que se llame al método, debe incrementar el contador y mostrarlo en pantalla.

using System;

class Program
{
    static int contadorAccesos = 0; // variable global

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nPresione ENTER para ejecutar el método o escriba 'salir' para terminar:");
            string entrada = Console.ReadLine().Trim().ToLower();

            if (entrada == "salir") break;

            MetodoConContador();
        }
    }

    static void MetodoConContador()
    {
        contadorAccesos++;
        Console.WriteLine($"El método se ha ejecutado {contadorAccesos} veces.");
    }
}
