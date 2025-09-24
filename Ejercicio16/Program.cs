//•	Crea una lista global que almacene nombres de usuarios registrados.
//•	Métodos con variables locales deben permitir:
//i.Registrar un nuevo usuario.
//ii.	Validar si un usuario ya existe.
//iii.	Mostrar todos los usuarios.



using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    //  Lista global que almacena nombres de usuarios registrados
    static List<string> usuarios = new List<string>();

    static void Main()
    {
        RegistrarUsuario();   // i. Registrar un nuevo usuario
        ValidarUsuario();     // ii. Validar si un usuario ya existe
        MostrarUsuarios();    // iii. Mostrar todos los usuarios
    }

    //  Método con variables locales para registrar un nuevo usuario
    static void RegistrarUsuario()
    {
        int intentos = 0;
        while (intentos < 3)
        {
            Console.Write("Ingrese el nombre de usuario: ");
            string usuario = Console.ReadLine()?.Trim().ToLower(); // variable local

            if (string.IsNullOrWhiteSpace(usuario))
            {
                Console.WriteLine("Error: El usuario no puede estar vacío");
                intentos++;
                continue;
            }

            // Validación: letras, números, guión bajo, longitud 3–20, no inicia con número
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

    //  Método con variables locales para validar si un usuario ya existe
    static void ValidarUsuario()
    {
        int intentos = 0;
        while (intentos < 3)
        {
            Console.Write("Ingrese el usuario a validar: ");
            string usuario = Console.ReadLine()?.Trim().ToLower(); // variable local

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

    //  Método con variables locales para mostrar todos los usuarios registrados
    static void MostrarUsuarios()
    {
        Console.WriteLine("Usuarios registrados:");
        foreach (string usuario in usuarios) // variable local en el bucle
        {
            Console.WriteLine($"- {usuario}");
        }
    }
}
