//5.	Edad de una persona con variables locales
//	Diseña un método que use variables locales para leer el año de nacimiento de una persona y calcule su edad. La edad no debe almacenarse de forma global.

class ProgramaEdad
{
    static void CalcularEdad()
    {
        Console.WriteLine("=== Cálculo de Edad ===");
        Console.WriteLine("Este programa calcula tu edad según el año de nacimiento.");

        int añoNacimiento = 0;
        int añoActual = DateTime.Now.Year;
        bool entradaValida = false;

        while (!entradaValida)
        {
            Console.Write("Ingresa tu año de nacimiento: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out añoNacimiento))
            {
                if (añoNacimiento > 1900 && añoNacimiento <= añoActual)
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine($"El año ingresado no es válido. Debe estar entre 1900 y {añoActual}.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingresa un número entero.");
            }
        }

        int edad = añoActual - añoNacimiento;
        Console.WriteLine($"Tu edad es: {edad} años.");
    }

    static void Main()
    {
        CalcularEdad();
    }
}