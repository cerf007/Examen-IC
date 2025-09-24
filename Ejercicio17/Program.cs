//17.Simulador de Tienda en Línea
//•	Declara una variable global carritoTotal.
//•	Crea métodos con variables locales para:
//	Agregar un producto (sumando su precio al total).
//	Eliminar un producto.
//	Consultar el total actual de la compra.

using System;

class Program
{
    // Variable global para el total del carrito
    static decimal carritoTotal = 0;

    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- Simulador de Tienda en Línea ---");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Eliminar producto");
            Console.WriteLine("3. Consultar total");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            // Validación de la opción ingresada
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    AgregarProducto();
                    break;
                case 2:
                    EliminarProducto();
                    break;
                case 3:
                    ConsultarTotal();
                    break;
                case 4:
                    Console.WriteLine("¡Gracias por usar la tienda!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        } while (opcion != 4);
    }

    // Método para agregar un producto al carrito
    static void AgregarProducto()
    {
        Console.Write("Ingrese el precio del producto a agregar: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal precio) && precio > 0)
        {
            carritoTotal += precio;
            Console.WriteLine($"Producto agregado. Total actual: ${carritoTotal:F2}");
        }
        else
        {
            Console.WriteLine("Precio no válido. Intente de nuevo.");
        }
    }

    // Método para eliminar un producto del carrito
    static void EliminarProducto()
    {
        Console.Write("Ingrese el precio del producto a eliminar: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal precio) && precio > 0)
        {
            if (precio > carritoTotal)
            {
                Console.WriteLine("No puede eliminar un monto mayor al total del carrito.");
            }
            else
            {
                carritoTotal -= precio;
                Console.WriteLine($"Producto eliminado. Total actual: ${carritoTotal:F2}");
            }
        }
        else
        {
            Console.WriteLine("Precio no válido. Intente de nuevo.");
        }
    }

    // Método para consultar el total actual del carrito
    static void ConsultarTotal()
    {
        Console.WriteLine($"El total actual de la compra es: ${carritoTotal:F2}");
    }
}
