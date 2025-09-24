using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    // Lista global que almacena nombres de usuarios registrados
    static List<string> usuarios = new List<string>();

    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n=== MENÚ DE USUARIOS ===");
            Console.WriteLine("1. Registrar nuevo usuario");
            Console.WriteLine("2. Validar usuario existente");
            Console.WriteLine("3. Mostrar todos los usuarios");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine()?.Trim();

            switch (opcion)
            {
                case "1":
                    RegistrarUsuario();
                    break;
                case "2":
                    ValidarUsuario();
                    break;
                case "3":
                    MostrarUsuarios();
                    break;
                case "4":
                    continuar = false;
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }
        }
    }

    // Método para registrar un nuevo usuario
    static void RegistrarUsuario()
    {
        int intentos = 0;
        while (intentos < 3)
        {
            Console.Write("Ingrese el nombre de usuario: ");
            string usuario = Console.ReadLine()?.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(usuario))
            {
                Console.WriteLine("Error: El usuario no puede estar vacío");
                intentos++;
                continue;
            }

            if (!Regex.IsMatch(usuario, @"^[a-zA-Z][a-zA-Z0-9_]{2,19}$"))
            {
                Console.WriteLine("Error: Formato inválido");
                intentos++;
                continue;
            }

            if (usuarios.Contains(usuario))
            {
                Console.WriteLine("Error: El usuario ya existe");
                return;
            }

            usuarios.Add(usuario);
            Console.WriteLine("Usuario registrado exitosamente");
            return;
        }

        Console.WriteLine("Se alcanzó el número máximo de intentos.");
    }

    // Método para validar si un usuario ya existe
    static void ValidarUsuario()
    {
        int intentos = 0;
        while (intentos < 3)
        {
            Console.Write("Ingrese el usuario a validar: ");
            string usuario = Console.ReadLine()?.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(usuario))
            {
                Console.WriteLine("Error: Debe ingresar un usuario");
                intentos++;
                continue;
            }

            if (usuarios.Contains(usuario))
            {
                Console.WriteLine("El usuario está registrado");
            }
            else
            {
                Console.WriteLine("El usuario NO existe");
            }
            return;
        }

        Console.WriteLine("Se alcanzó el número máximo de intentos.");
    }

    // Método para mostrar todos los usuarios registrados
    static void MostrarUsuarios()
    {
        Console.WriteLine("Usuarios registrados:");
        foreach (string usuario in usuarios)
        {
            Console.WriteLine($"- {usuario}");
        }
    }
}