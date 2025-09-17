using System;

 public class Program
{
    public static void Main()
    {
        string contraseñaPredefinida = "admin1234"; //Contraseña correcta
        string contraseñaIngresada = ""; //Variable donde se guarda la contraseña ingresada por el usuario

        while (contraseñaIngresada != contraseñaPredefinida)
        {
            Console.WriteLine("Introduce la contraseña: ");
            contraseñaIngresada = Console.ReadLine();

            if (contraseñaIngresada == contraseñaPredefinida)
            {
                Console.WriteLine("¡Contraseña correcta! \nIngresando al sistema... ");
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta. Intentálo de nuevo.");
            }
        }
    }
}