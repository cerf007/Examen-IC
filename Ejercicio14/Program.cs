//14.Gestión de Notas de Estudiantes
//•	Declara una lista global que almacene todas las notas.
//•	Métodos locales deben:
//	Agregar una nota.
//	Calcular el promedio (solo con variables locales).
//	Mostrar la nota más alta y la más baja.


///Gestión de notas de estudiantes
using System;
using System.Collections.Generic;

class Program
{
    // 1. Declara una lista global que almacene todas las notas.
    static List<double> notas = new List<double>();

    static void Main()
    {
        Console.WriteLine("=== GESTIÓN DE NOTAS DE ESTUDIANTES ===");

        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("\n1. Agregar nota");
            Console.WriteLine("2. Calcular promedio");
            Console.WriteLine("3. Mostrar notas extremas");
            Console.WriteLine("4. Mostrar todas las notas");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarNota(); //  Agregar una nota.
                    break;
                case "2":
                    CalcularPromedio(); //  Calcular el promedio (solo con variables locales).
                    break;
                case "3":
                    MostrarNotasExtremas(); //  Mostrar la nota más alta y la más baja.
                    break;
                case "4":
                    MostrarTodasLasNotas();
                    break;
                case "5":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }

    //  Método local para agregar una nota.
    static void AgregarNota()
    {
        try
        {
            Console.Write("Ingrese la nota (0-100): ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error: La nota no puede estar vacía");
                return;
            }

            double nota = Convert.ToDouble(input);

            if (nota < 0 || nota > 100)
            {
                Console.WriteLine("Error: La nota debe estar entre 0 y 100");
                return;
            }

            if (double.IsNaN(nota) || double.IsInfinity(nota))
            {
                Console.WriteLine("Error: La nota no es un número válido");
                return;
            }

            notas.Add(Math.Round(nota, 2));
            Console.WriteLine($"Nota {Math.Round(nota, 2)} agregada correctamente");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debe ingresar un número válido");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: El número es demasiado grande");
        }
    }

    //  Método local para calcular el promedio (solo con variables locales).
    static void CalcularPromedio()
    {
        if (notas.Count == 0)
        {
            Console.WriteLine("Error: No hay notas registradas");
            return;
        }

        double suma = 0;
        int cantidad = notas.Count;

        foreach (double nota in notas)
        {
            suma += nota;
        }

        double promedio = suma / cantidad;
        Console.WriteLine($"Promedio de {cantidad} notas: {promedio:F2}");
    }

    //  Método local para mostrar la nota más alta y la más baja.
    static void MostrarNotasExtremas()
    {
        if (notas.Count == 0)
        {
            Console.WriteLine("Error: No hay notas registradas");
            return;
        }

        double maxima = notas.Max();
        double minima = notas.Min();

        Console.WriteLine($"Nota más alta: {maxima:F2}");
        Console.WriteLine($"Nota más baja: {minima:F2}");
        Console.WriteLine($"Rango: {maxima - minima:F2}");
    }

    static void MostrarTodasLasNotas()
    {
        if (notas.Count == 0)
        {
            Console.WriteLine("No hay notas registradas");
            return;
        }

        Console.WriteLine($"Total de notas: {notas.Count}");
        for (int i = 0; i < notas.Count; i++)
        {
            Console.WriteLine($"Nota {i + 1}: {notas[i]:F2}");
        }
    }
}