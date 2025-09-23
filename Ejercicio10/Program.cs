//10.Juego de puntuación con variables globales
//	Declara una variable global puntuacion. Cada vez que se llame al método GanarPuntos, la puntuación debe aumentar en 10 y mostrarse en pantalla.

using System;

class Program;
{
    static int puntuacion = 0;
    static void Main()
    {
       bool seguir = true;
       while (!seguir)
       {
            Console.WriteLine("Ingrese la siguientes opciones");
            Console.WriteLine("1. Aumentar Puntucación");
            Console.WriteLine("2. Salir del programa");
            int opcion = (int.TryParse(Console.ReadLine(), out opcion)
                {

            }

            switch(opcion)
            {
                case 1:
                    GanarPuntos()
                case 2: GanarPuntos()
                default

            }

       }
    }
    
}