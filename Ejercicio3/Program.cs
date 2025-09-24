//3.Conversor de temperatura con variable global
//	Declara una variable global que indique la escala de conversión (ejemplo: Celsius a Fahrenheit). Haz un método que use esa variable para realizar la conversión.

using System;
class Program
{
    static string escalaConversion = "CtoF"; // variable global

    static void Main(string[] args)
    {
        Console.WriteLine("Conversor de temperatura.");
        Console.WriteLine("Escala actual: CtoF (Celsius a Fahrenheit)");

        while (true)
        {
            Console.WriteLine("\nOpciones:");
            Console.WriteLine("1. Cambiar escala");
            Console.WriteLine("2. Convertir temperatura");
            Console.WriteLine("3. Salir");

            int opcion = LeerEntero("Seleccione una opción: ");

            if (opcion == 1)
                CambiarEscala();
            else if (opcion == 2)
                ConvertirTemperatura();
            else if (opcion == 3)
                break;
            else
                Console.WriteLine("Opción inválida.");
        }
    }

    static void CambiarEscala()
    {
        Console.Write("Ingrese nueva escala (CtoF / FtoC): ");
        string nueva = Console.ReadLine().Trim();
        if (nueva == "CtoF" || nueva == "FtoC")
        {
            escalaConversion = nueva;
            Console.WriteLine($"Escala cambiada a: {escalaConversion}");
        }
        else
        {
            Console.WriteLine("Escala inválida. Se mantiene la actual.");
        }
    }

    static void ConvertirTemperatura()
    {
        double valor = LeerDecimal("Ingrese la temperatura: ");
        double resultado;

        if (escalaConversion == "CtoF")
        {
            resultado = (valor * 9 / 5) + 32;
            Console.WriteLine($"{valor} °C = {resultado} °F");
        }
        else
        {
            resultado = (valor - 32) * 5 / 9;
            Console.WriteLine($"{valor} °F = {resultado} °C");
        }
    }

    static int LeerEntero(string mensaje)
    {
        int valor;
        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out valor))
                return valor;
            else
                Console.WriteLine("Entrada inválida. Ingrese un número entero.");
        }
    }

    static double LeerDecimal(string mensaje)
    {
        double valor;
        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();
            if (double.TryParse(entrada, out valor))
                return valor;
            else
                Console.WriteLine("Entrada inválida. Ingrese un número válido.");
        }
    }
}

