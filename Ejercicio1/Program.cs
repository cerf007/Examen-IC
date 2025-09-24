//1.Contador de accesos global
//	Declara una variable global que almacene el número de veces que se ha ejecutado un método. Cada vez que se llame al método, debe incrementar el contador y mostrarlo en pantalla.

using System;
using System.ComponentModel.Design;

class Program
{
    static int contadorAccesos = 0; // variable global

    static void Main(string[] args)
    {
        while (true)
        {
            int opcion;
            Console.WriteLine("Seleccione la ocpcion que desea llevar a cabo");
            Console.WriteLine("1. Ejecutar metodo y ver contador");
            Console.WriteLine("2. Salir");
            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcion))
            {
                Console.WriteLine("Formato no válido, ingrese un número entero");
                continue;
            }

            switch(opcion)
            {
                case 1:
                    MetodoConContador();
                    continue;
                case 2:
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opcion no válida, elija los numeros 1 o 2");
                    continue;
            }
        }
    }

    static void MetodoConContador()
    {
        contadorAccesos++;
        Console.WriteLine($"El método se ha ejecutado {contadorAccesos} veces.");
    }
}
