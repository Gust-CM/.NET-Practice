using System;

public class Program
{
    public static void Main()
    {
        int opcion; //Variable para almacenar la opción del usuario

        do
        {
            Console.WriteLine("\n--- Menú Interactivo ---"); //Inicio del menú interactivo
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Fecha de hoy");
            Console.WriteLine("3. Salir del menú");
            Console.WriteLine("Seleccione una opción entre 1, 2 o 3");

            opcion = Convert.ToInt32(Console.ReadLine()); //Lee la opción del usuario

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("¡Hola! ¿Cómo estás?");
                    break;
                case 2:
                    Console.WriteLine($"La fecha de hoy es: {DateTime.Now}");
                    break;
                case 3:
                    Console.WriteLine($"Saliendo del menú, digitaste la opción: {opcion}");
                    break;
                default:
                    Console.WriteLine($"Digitaste la opción: {opcion} agrega una opción correcta."); break;
            }
        }
        while (opcion != 3); //El menú se repetirá hasta que el usuario elija la opción 3 para salir del menú
    }
}