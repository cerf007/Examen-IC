// Control de sesión con variable global
using System;

class ControlSesion
{
    static bool sesionIniciada = false; // Variable global para controlar el estado de sesión

    static void IniciarSesion()
    {
        Console.WriteLine("=== Inicio de Sesión ===");
        Console.WriteLine("Ingresa la contraseña para acceder al sistema.");

        string contraseñaCorrecta = "1234";

        Console.Write("Contraseña: ");
        string entrada = Console.ReadLine();

        // Validamos que la entrada no esté vacía
        if (!string.IsNullOrWhiteSpace(entrada))
        {
            if (entrada == contraseñaCorrecta)
            {
                sesionIniciada = true;
                Console.WriteLine("Sesión iniciada correctamente.");
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta.");
            }
        }
        else
        {
            Console.WriteLine("La entrada no puede estar vacía.");
        }
    }

    static void Main()
    {
        IniciarSesion();

        // Indicamos si el acceso fue exitoso o no
        if (sesionIniciada)
        {
            Console.WriteLine("Bienvenido al sistema.");
        }
        else
        {
            Console.WriteLine("Acceso denegado.");
        }
    }
}
