//Simulación de Cajero Automático
//	Usa una variable global que represente el saldo de una cuenta bancaria.
//	Implementa métodos con variables locales para:
//      1.Depositar dinero.
//      2.Retirar dinero(validando que no exceda el saldo).
//      3.Consultar saldo.


using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static double saldo = 0;
    static void Main()
    {
        while (true)
        {
            int opcion;
            Console.WriteLine("Ingrese una de las siguientes opciones a realzar");
            Console.WriteLine("1. Depositar");
            Console.WriteLine("2. Retirar dinero");
            Console.WriteLine("3. Consultar saldo");
            Console.WriteLine("4. Salir");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese un numero válido");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    Depositar();
                    break;
                case 2:
                    Retirar();
                    break;
                case 3:
                    ConsultarSaldo();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("El numero ingresado no esta en la lista de opciones");
                    break;
            }
        }
    } 

    static void Depositar()
    {
        double deposito;
        Console.WriteLine("Ingrese la cantidad a depositar: ");
        while (!double.TryParse(Console.ReadLine(), out deposito) || deposito <= 0)
        {
            Console.WriteLine("Formato o cantidad inválida");
            return;
        }
        saldo = saldo + deposito;

        Console.WriteLine($"El balance de su cuenta ha sido actualizado a {saldo}");
        return;
    }

    static void Retirar()
    {
        double retiro;
        Console.WriteLine("Digite la cantidad de dinero a retirar:");
        while (true)
        {
            if (!double.TryParse(Console.ReadLine(), out retiro) || retiro <= 0)
            {
                Console.WriteLine("Formato o cantidad inválida");
                return;
            }

            if (retiro > saldo)
            {
                Console.WriteLine("Fondos insuficientes. Saldo disponible: {0:C}", saldo);
                return;
            }
            break;
        }

        saldo = saldo - retiro;
        Console.WriteLine($"El balance de su cuenta ha sido actualizado a {saldo}");
    }
    static void ConsultarSaldo()
    {
        Console.WriteLine("El saldo actual de su cuenta es de {0:C}", saldo);
        return;
    }
}




