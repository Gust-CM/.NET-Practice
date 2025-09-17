using System;

public class Program
{
    public static void Main()
    {
        int respuesta;
        do
        {
            Console.WriteLine("Introduce una palabra:");
            string palabra = Console.ReadLine().ToLower();
            bool esPalindromo = true;

            for (int i = 0; i < palabra.Length / 2; i++)
            {
                if (palabra[i] != palabra[palabra.Length - 1 - i])
                {
                    esPalindromo = false;
                    break; // Salimos del bucle si encontramos una diferencia
                }
            }

            if (esPalindromo)
            {
                Console.WriteLine("La palabra es un palíndromo.");
            }
            else
            {
                Console.WriteLine("La palabra no es un palíndromo.");
            }

            Console.WriteLine("¿Quieres hacer otra validación? 1.Sí 2.No");
            // TryParse evita excepciones si la entrada no es un número
            int.TryParse(Console.ReadLine(), out respuesta);
        }
        while (respuesta == 1);
    }
}