// Descripción: Juego simple de adivinanza con conteo de intentos usando variable global.
using System;

class JuegoIntentos
{
    static int intentos = 0; // Variable global para contar los intentos

    static void Jugar()
    {
        Console.WriteLine("=== Juego de Adivinanza ===");
        Console.WriteLine("Adivina el número secreto entre 1 y 10.");

        int numeroSecreto = 7;
        int intentoUsuario = 0;

        while (intentoUsuario != numeroSecreto)
        {
            Console.Write("Tu intento: ");
            string entrada = Console.ReadLine();

            // Validamos que el usuario haya ingresado un número
            if (int.TryParse(entrada, out intentoUsuario))
            {
                intentos++;

                if (intentoUsuario != numeroSecreto)
                {
                    Console.WriteLine("Incorrecto. Intenta de nuevo.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
            }
        }

        Console.WriteLine($"¡Correcto! Lo lograste en {intentos} intentos.");
    }

    static void Main()
    {
        Jugar();
    }
}
