//14.Gestión de Notas de Estudiantes
//•	Declara una lista global que almacene todas las notas.
//•	Métodos locales deben:
//	Agregar una nota.
//	Calcular el promedio (solo con variables locales).
//	Mostrar la nota más alta y la más baja.


///Gestión de notas de estudiantes
using System;

class Program
{
    // 1. Usa una variable global para almacenar el número secreto.
    static int numeroSecreto = new Random().Next(1, 101); // Número secreto generado aleatoriamente
    static int intentosTotales = 0; // Contador global de intentos

    static void Main()
    {
        Console.WriteLine("=== JUEGO DE ADIVINANZA MEJORADO ===");
        Console.WriteLine("Adivina el número secreto entre 1 y 100");

        Jugar();
    }

    // 2. Un método con variables locales debe pedir al usuario que adivine.
    static void Jugar()
    {
        int intentoUsuario; // Variable local
        bool adivinado = false; // Variable local

        while (!adivinado)
        {
            intentoUsuario = PedirIntento();
            if (intentoUsuario != -1) // -1 indica error de validación
            {
                adivinado = VerificarIntento(intentoUsuario);
            }
        }
    }

    static int PedirIntento()
    {
        try
        {
            Console.Write("Ingresa tu número (1-100): ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error: Debes ingresar un número");
                return -1;
            }

            int intento = Convert.ToInt32(input);

            if (intento < 1 || intento > 100)
            {
                Console.WriteLine("Error: El número debe estar entre 1 y 100");
                return -1;
            }

            return intento;
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Debes ingresar un número válido");
            return -1;
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: El número es demasiado grande");
            return -1;
        }
    }

    // 3. Otro método debe aumentar un contador global de intentos y mostrar un mensaje de acierto o error.
    static bool VerificarIntento(int intento)
    {
        intentosTotales++; // Incrementa el contador global

        if (intento == numeroSecreto)
        {
            Console.WriteLine($"¡FELICIDADES! Adivinaste en {intentosTotales} intentos");
            return true;
        }
        else if (intento < numeroSecreto)
        {
            Console.WriteLine("El número secreto es MAYOR");
        }
        else
        {
            Console.WriteLine("El número secreto es MENOR");
        }

        Console.WriteLine($"Intentos realizados: {intentosTotales}");
        return false;
    }
}