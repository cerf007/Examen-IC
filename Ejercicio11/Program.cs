//Sistema de Inventario simplificado
//•	Declara una variable global que almacene el total de productos en inventario.
//•	Crea métodos locales para:
//	    Agregar productos.
//	    Retirar productos.
//	Consultar el inventario actual.
//      Cada acción debe actualizar la variable global y mostrar los resultados.

using System;

class Program
{
    static int totalProductos = 0;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Agregar productos");
            Console.WriteLine("2. Retirar productos");
            Console.WriteLine("3. Consultar inventario");
            Console.WriteLine("4. Salir");

            int num;
            bool esNumero = int.TryParse(Console.ReadLine(), out num);
            if (!esNumero)
            {
                Console.WriteLine("Opción inválida");
                continue;
            }

            switch (num)
            {
                case 1:
                    AgregarProductos();
                    break;
                case 2:
                    RetirarProductos();
                    break;
                case 3:
                    ConsultarInventario();
                    break;
                case 4:
                    Console.WriteLine("Saliendo del sistema...");
                    return;
                default:
                    Console.WriteLine("Opción inválida, ingrese un número del 1 al 4");
                    break;
            }
        }
    }

    static void AgregarProductos()
    {
        Console.Write("Ingrese la cantidad a agregar: ");
        if (int.TryParse(Console.ReadLine(), out int cantidad))
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor que cero.");
                return;
            }

            totalProductos += cantidad;
            Console.WriteLine($"Se agregaron {cantidad} productos. Total actual: {totalProductos}");
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }

    static void RetirarProductos()
    {
        Console.Write("Ingrese la cantidad a retirar: ");
        if (int.TryParse(Console.ReadLine(), out int cantidad))
        {
            if (cantidad <= 0)
            {
                Console.WriteLine("La cantidad debe ser mayor que cero.");
                return;
            }

            if (cantidad > totalProductos)
            {
                Console.WriteLine("No hay suficientes productos para retirar esa cantidad.");
                return;
            }

            totalProductos -= cantidad;
            Console.WriteLine($"Se retiraron {cantidad} productos. Total actual: {totalProductos}");
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }

    static void ConsultarInventario()
    {
        Console.WriteLine($"Inventario actual: {totalProductos} productos.");
    }
}