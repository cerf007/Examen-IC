// Promedio de notas con variables locales
using System;

class PromedioNotas
{
    static void CalcularPromedio()
    {
        Console.WriteLine("=== Cálculo de Promedio ===");
        Console.WriteLine("Este programa calcula el promedio de tres notas.");

        double[] notas = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Ingresa la nota {i + 1} (0 a 100): ");
            string entrada = Console.ReadLine();

            // Validamos que la nota sea un número entre 0 y 100
            if (double.TryParse(entrada, out double nota) && nota >= 0 && nota <= 100)
            {
                notas[i] = nota;
            }
            else
            {
                Console.WriteLine("Nota inválida. Debe estar entre 0 y 100.");
                i--; // Repetimos el intento
            }
        }

        double promedio = (notas[0] + notas[1] + notas[2]) / 3;
        Console.WriteLine($"El promedio de las notas es: {promedio:F2}");
    }

    static void Main()
    {
        CalcularPromedio();
    }
}