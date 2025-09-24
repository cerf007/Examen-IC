//8.Control de sesión con variable global
//	Declara una variable global booleana sesionIniciada. Simula un inicio de sesión que la cambie a true cuando el usuario ingrese la contraseña correcta.

using System;

class ControlSesion
{
    static bool sesionIniciada = false; // Variable global para controlar el estado de sesión
    const string contraseñaCorrecta = "1234";
    const int maxIntentos = 3;

    static void IniciarSesion()
    {
        Console.WriteLine("=== Inicio de Sesión ===");
        Console.WriteLine("Ingresa la contraseña para acceder al sistema.");

        int intentosRestantes = maxIntentos;

        while (intentosRestantes > 0 && !sesionIniciada)
        {
            Console.Write("Contraseña: ");
            string entrada = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine(" La entrada no puede estar vacía.");
            }
            else if (ValidarContraseña(entrada))
            {
                sesionIniciada = true;
                Console.WriteLine(" Sesión iniciada correctamente.");
            }
            else
            {
                intentosRestantes--;
                Console.WriteLine($" Contraseña incorrecta. Intentos restantes: {intentosRestantes}");
            }
        }

        if (!sesionIniciada)
        {
            Console.WriteLine(" Se ha alcanzado el número máximo de intentos.");
        }
    }

    static bool ValidarContraseña(string entrada)
    {
        return entrada == contraseñaCorrecta;
    }

    static void Main()
    {
        try
        {
            IniciarSesion();

            if (sesionIniciada)
            {
                Console.WriteLine(" Bienvenido al sistema.");
            }
            else
            {
                Console.WriteLine(" Acceso denegado.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($" Error inesperado: {ex.Message}");
        }
    }
}
