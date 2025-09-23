// Edad de una persona con variables locales
using System;

class ProgramaEdad
{
    static void CalcularEdad()
    {
        Console.WriteLine("=== Cálculo de Edad ===");
        Console.WriteLine("Este programa calcula tu edad según el año de nacimiento.");

        Console.Write("Ingresa tu año de nacimiento: ");
        string entrada = Console.ReadLine();

        // Validamos que el usuario haya ingresado un número válido
        if (int.TryParse(entrada, out int añoNacimiento))
        {
            int añoActual = DateTime.Now.Year;

            if (añoNacimiento > 1900 && añoNacimiento <= añoActual)
            {
                int edad = añoActual - añoNacimiento;
                Console.WriteLine($"Tu edad es: {edad} años.");
            }
            else
            {
                Console.WriteLine("El año ingresado no es válido. Debe estar entre 1900 y el año actual.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingresa un número.");
        }
    }

    static void Main()
    {
        CalcularEdad();
    }
}