//20. Número capicúa(palíndromo numérico)

//Crea un programa que:
//•	Pida al usuario un número entero positivo.
//•	Determine si ese número es capicúa (por ejemplo, 121, 1331).
//•	Usa una función para invertir el número (no con arreglos).
//•	Compara el número original con el invertido.
//•	Usa una variable global para el número original y funciones auxiliares para la inversión.

//Requisitos técnicos:
//•	Función con retorno.
//•	Sin arreglos ni manipulación de cadenas (usa operadores matemáticos).
// b •	Uso de variables globales/locales.

using System;

class Program
{
    // Variable global para almacenar el número original
    static int numeroOriginal;

    static void Main()
    {
        // Solicita al usuario un número entero positivo
        Console.Write("Introduce un número entero positivo: ");
        while (!int.TryParse(Console.ReadLine(), out numeroOriginal) || numeroOriginal < 0)
        {
            Console.Write("Entrada no válida. Introduce un número entero positivo: ");
        }

        // Invierte el número usando una función auxiliar
        int numeroInvertido = InvertirNumero(numeroOriginal);

        // Compara el número original con el invertido
        if (numeroOriginal == numeroInvertido)
        {
            Console.WriteLine($"{numeroOriginal} es un número capicúa.");
        }
        else
        {
            Console.WriteLine($"{numeroOriginal} no es un número capicúa.");
        }
    }

    // Función auxiliar para invertir el número (sin arreglos ni cadenas)
    static int InvertirNumero(int n)
    {
        int invertido = 0;
        while (n > 0)
        {
            invertido = invertido * 10 + n % 10;
            n /= 10;
        }
        return invertido;
    }
}