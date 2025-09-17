using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Introduce la cantidad de números pares que quieres visualizar: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int contadorPares = 0;
        int numeroActual = 0;

        while (contadorPares < n)
        {
            if (numeroActual % 2 == 0) //Verificamos si el número actual es par
            {
                Console.WriteLine(numeroActual);
                contadorPares++; //Incrementa el contador de números
            }
            numeroActual++;
        }
    }
}