//19. Desarrolla un programa que:

//Pida al usuario ingresar una fecha (día, mes, año).
//Valide si la fecha es válida (mes entre 1-12, días válidos según el mes, etc.).
//•	Determine si el año es bisiesto.
//•	Use funciones para cada validación (por ejemplo, EsBisiesto, DiaValido, MesValido).
//•	Muestra si la fecha ingresada es correcta o no.

//Requisitos técnicos:
//	Funciones para validaciones lógicas.
//	Uso de variables locales y globales.

using System;

class Program
{
    // Variables globales para la fecha
    static int dia, mes, año;

    static void Main()
    {
        // Solicita al usuario ingresar el día, mes y año
        Console.Write("Ingrese el día: ");
        while (!int.TryParse(Console.ReadLine(), out dia) || dia < 1)
        {
            Console.Write("Día no válido. Ingrese un día válido: ");
        }

        Console.Write("Ingrese el mes: ");
        while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12)
        {
            Console.Write("Mes no válido. Ingrese un mes entre 1 y 12: ");
        }

        Console.Write("Ingrese el año: ");
        while (!int.TryParse(Console.ReadLine(), out año) || año < 1)
        {
            Console.Write("Año no válido. Ingrese un año positivo: ");
        }

        // Validación de la fecha
        if (FechaValida(dia, mes, año))
        {
            Console.WriteLine("La fecha ingresada es correcta.");
            if (EsBisiesto(año))
                Console.WriteLine($"{año} es un año bisiesto.");
            else
                Console.WriteLine($"{año} no es un año bisiesto.");
        }
        else
        {
            Console.WriteLine("La fecha ingresada NO es válida.");
        }
    }

    // Valida si el año es bisiesto
    static bool EsBisiesto(int a)
    {
        return (a % 4 == 0 && a % 100 != 0) || (a % 400 == 0);
    }

    // Valida si el mes es válido (1-12)
    static bool MesValido(int m)
    {
        return m >= 1 && m <= 12;
    }

    // Valida si el día es válido según el mes y el año
    static bool DiaValido(int d, int m, int a)
    {
        int[] diasPorMes = { 31, EsBisiesto(a) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        return d >= 1 && d <= diasPorMes[m - 1];
    }

    // Valida la fecha completa
    static bool FechaValida(int d, int m, int a)
    {
        return MesValido(m) && DiaValido(d, m, a);
    }
}