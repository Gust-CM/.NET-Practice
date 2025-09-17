using System;
public class Program
{
    public static void Main()
    {
        int acumulador = 0;
        int numero = 1;

        Console.WriteLine("Introduce números para sumar. Escribe 0 para terminar.");

        while (numero != 0) //Se repite mientras sea distinto a 0.
        {
            Console.WriteLine("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            acumulador += numero; //Acumulamos la suma de los números
        }

        Console.WriteLine($"La suma es: {acumulador}");
    }
}