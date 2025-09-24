// 18. Validador de contraseñas seguras
// Diseña un programa que valide si una contraseña ingresada cumple los siguientes requisitos:
// • Mínimo 8 caracteres
// • Al menos una mayúscula
// • Al menos una minúscula
// • Al menos un número
// • Al menos un carácter especial (!@#$%^&*)

using System;

class Program
{
    static void Main()
    {
        // Solicita al usuario que ingrese una contraseña
        Console.Write("Ingrese una contraseña: ");
        string password = Console.ReadLine();

        // Valida la contraseña usando la función principal de validación
        bool esValida = EsContraseñaValida(password);

        // Muestra el resultado de la validación
        if (esValida)
            Console.WriteLine("La contraseña es válida");
        else
            Console.WriteLine("La contraseña no cumple los requisitos");
    }

    // Función principal que verifica todos los requisitos de la contraseña
    static bool EsContraseñaValida(string pass)
    {
        return TieneLongitudMinima(pass)
            && TieneMayuscula(pass)
            && TieneMinuscula(pass)
            && TieneNumero(pass)
            && TieneCaracterEspecial(pass);
    }

    // Verifica si la contraseña tiene al menos 8 caracteres
    static bool TieneLongitudMinima(string pass)
    {
        return pass.Length >= 8;
    }

    // Verifica si la contraseña contiene al menos una letra mayúscula
    static bool TieneMayuscula(string pass)
    {
        foreach (char c in pass)
        {
            if (char.IsUpper(c))
                return true;
        }
        return false;
    }

    // Verifica si la contraseña contiene al menos una letra minúscula
    static bool TieneMinuscula(string pass)
    {
        foreach (char c in pass)
        {
            if (char.IsLower(c))
                return true;
        }
        return false;
    }

    // Verifica si la contraseña contiene al menos un número
    static bool TieneNumero(string pass)
    {
        foreach (char c in pass)
        {
            if (char.IsDigit(c))
                return true;
        }
        return false;
    }

    // Verifica si la contraseña contiene al menos un carácter especial permitido
    static bool TieneCaracterEspecial(string pass)
    {
        string especiales = "!@#$%^&*";
        foreach (char c in pass)
        {
            if (especiales.Contains(c))
                return true;
        }
        return false;
    }
}