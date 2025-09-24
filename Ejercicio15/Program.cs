//15.Calculadora Científica Básica
//•	Usa una variable global para guardar el último resultado calculado.
//•	Crea métodos con variables locales para realizar:
//i.Suma, resta, multiplicación y división.
//ii.	Potencias y raíces cuadradas.
//b.	Cada vez que se realice una operación, el último resultado debe actualizarse en la variable global.

using System;

class Program
{
    // a. Usa una variable global para guardar el último resultado calculado.
    static double ultimoResultado = 0;

    static void Main()
    {
        Console.WriteLine("=== CALCULADORA CIENTÍFICA BÁSICA ===");

        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine($"\nÚltimo resultado: {ultimoResultado:F2}");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Raíz cuadrada");
            Console.WriteLine("7. Limpiar resultado");
            Console.WriteLine("8. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    OperacionSumar(); // a.i. Suma
                    break;
                case "2":
                    OperacionRestar(); // a.i. Resta
                    break;
                case "3":
                    OperacionMultiplicar(); // a.i. Multiplicación
                    break;
                case "4":
                    OperacionDividir(); // a.i. División
                    break;
                case "5":
                    OperacionPotencia(); // a.ii. Potencias
                    break;
                case "6":
                    OperacionRaizCuadrada(); // a.ii. Raíz cuadrada
                    break;
                case "7":
                    ultimoResultado = 0;
                    Console.WriteLine("Resultado limpiado");
                    break;
                case "8":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }

    // Método auxiliar para leer números con validación
    static double LeerNumero(string mensaje)
    {
        while (true)
        {
            try
            {
                Console.Write(mensaje);
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Error: Debe ingresar un número");
                    continue;
                }

                double numero = Convert.ToDouble(input);

                if (double.IsNaN(numero) || double.IsInfinity(numero))
                {
                    Console.WriteLine("Error: Número no válido");
                    continue;
                }

                return numero;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Formato de número inválido");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Número demasiado grande");
            }
        }
    }

    // a.i. Método local para sumar
    // b. Actualiza el último resultado
    static void OperacionSumar()
    {
        double a = LeerNumero("Ingrese primer número: ");
        double b = LeerNumero("Ingrese segundo número: ");

        double resultado = a + b;
        ultimoResultado = resultado;
        Console.WriteLine($"{a} + {b} = {resultado:F2}");
    }

    // a.i. Método local para restar
    static void OperacionRestar()
    {
        double a = LeerNumero("Ingrese primer número: ");
        double b = LeerNumero("Ingrese segundo número: ");

        double resultado = a - b;
        ultimoResultado = resultado;
        Console.WriteLine($"{a} - {b} = {resultado:F2}");
    }

    // a.i. Método local para multiplicar
    static void OperacionMultiplicar()
    {
        double a = LeerNumero("Ingrese primer número: ");
        double b = LeerNumero("Ingrese segundo número: ");

        double resultado = a * b;
        ultimoResultado = resultado;
        Console.WriteLine($"{a} × {b} = {resultado:F2}");
    }

    // a.i. Método local para dividir
    static void OperacionDividir()
    {
        double a = LeerNumero("Ingrese dividendo: ");
        double b = LeerNumero("Ingrese divisor: ");

        if (b == 0)
        {
            Console.WriteLine("Error: No se puede dividir por cero");
            return;
        }

        double resultado = a / b;
        ultimoResultado = resultado;
        Console.WriteLine($"{a} ÷ {b} = {resultado:F2}");
    }

    // a.ii. Método local para potencia
    static void OperacionPotencia()
    {
        double baseNum = LeerNumero("Ingrese la base: ");
        double exponente = LeerNumero("Ingrese el exponente: ");

        if (Math.Abs(exponente) > 1000)
        {
            Console.WriteLine("Error: Exponente demasiado grande");
            return;
        }

        double resultado = Math.Pow(baseNum, exponente);
        ultimoResultado = resultado;
        Console.WriteLine($"{baseNum} ^ {exponente} = {resultado:F2}");
    }

    // a.ii. Método local para raíz cuadrada
    static void OperacionRaizCuadrada()
    {
        double numero = LeerNumero("Ingrese el número: ");

        if (numero < 0)
        {
            Console.WriteLine("Error: No se puede calcular raíz de número negativo");
            return;
        }

        double resultado = Math.Sqrt(numero);
        ultimoResultado = resultado;
        Console.WriteLine($"√{numero} = {resultado:F2}");
    }
}