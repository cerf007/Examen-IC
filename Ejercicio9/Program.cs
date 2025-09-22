//9.Perímetro de un círculo con variables locales
//Escribe un método que reciba el radio como parámetro, calcule el perímetro y lo retorne usando únicamente variables locales.
using System;
using System.Data;

class Program
{
    static void Main()
    {
        PedirNum();
        Console.ReadKey();
    }

    static void PedirNum()
    {
        Console.WriteLine("Ingrese el valor del radio: ");
        double radio;
        while (!double.TryParse(Console.ReadLine(), out radio) || radio <= 0)
        {
            Console.Write("Formato no válido. Ingrese un número positivo: ");
        }    
        double perimetro = CalcularPerimetro(radio);
        Console.WriteLine($"El perimetro del circulo es {perimetro}");
    }

    static double CalcularPerimetro(double r)
    {
        double perimetro = 2 * (Math.PI * r);
        return perimetro;
    }
}