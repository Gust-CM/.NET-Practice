using System;

public class Program
{
    public static void Main()
    {
        int opcion = 0;
        do
        {
            Console.WriteLine("Introduce un número para ver su tabla de multiplicar");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i)); //Mostramos la multiplicación
            }
            Console.WriteLine("¿Quieres ingresar otro número? 1.Sí 2.No "); //Preguntamos si quiere ingresar otro número
            opcion = Convert.ToInt32(Console.ReadLine());
        }
        while (opcion == 1);
    }
}