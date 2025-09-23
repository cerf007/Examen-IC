using System;

class Program
{
    static int puntuacion = 0;

    static void Main()
    {
        bool seguir = true;

        while (seguir)
        {
            Console.WriteLine("Ingrese una opción:");
            Console.WriteLine("1. Aumentar puntuación");
            Console.WriteLine("2. Salir del programa");

            string entrada = Console.ReadLine();
            int opcion;

            if (int.TryParse(entrada, out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        GanarPuntos();
                        break;
                    case 2:
                        seguir = false;
                        Console.WriteLine("¡Gracias por jugar!");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor ingrese un número.");
            }
        }
    }

    static void GanarPuntos()
    {
        puntuacion += 10;
        Console.WriteLine($"¡Has ganado 10 puntos! Puntuación actual: {puntuacion}");
    }
}