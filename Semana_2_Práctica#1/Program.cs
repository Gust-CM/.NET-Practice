using System;

public class Program
{
    public static void Main()
    {
        int opcion; opcion = 0;
        do
        {
            Console.WriteLine("Introduce un número: ");
            if (!int.TryParse(Console.ReadLine(), out int numero)) //Si el usuario ingresa un valor no númerico, el programa se detiene.
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
                continue;
            }

            if (numero % 2 == 0)
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es impar.");
            }

            Console.WriteLine("¿Desea ingresar otro número? 1.Sí 2.No");
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Entrada inválida. Saliendo del programa.");
                break;
            }
        }
        while (opcion == 1);
    }
}