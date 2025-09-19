using System;

public class Program
{
    public static void Main()
    {
        double suma = 0;
        int contador = 0;
        double numero;

        Console.WriteLine("Ingrese números para calcular el promedio. Escribe -1 para terminar");

        do
        {
            Console.WriteLine("Introduce un número: ");
            numero = Convert.ToDouble(Console.ReadLine());

            if (numero != -1)
            {
                suma += numero;
                contador++;
            }
        }
        while (numero != -1);

        if (contador > 0)
        {
            double promedio = suma / contador;
            Console.WriteLine($"El promedio es: {promedio}");
        }
        else
        {
            Console.WriteLine("No se ingresaron los datos suficientes. ");
        }
    }
}