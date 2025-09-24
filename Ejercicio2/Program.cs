//2.Área de un rectángulo con variables locales
//	Crea un método que pida la base y altura de un rectángulo, use variables locales para calcular el área y la imprima en pantalla.

using System;

class Program
{
    static void Main(string[] args)
    {
        double baseRect = LeerDecimal("Ingrese la base del rectángulo: ");
        double alturaRect = LeerDecimal("Ingrese la altura del rectángulo: ");

        double area = baseRect * alturaRect; // variables locales
        Console.WriteLine($"El área del rectángulo es: {area}");
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