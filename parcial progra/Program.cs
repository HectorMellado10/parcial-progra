using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("Elija una opción:");
            Console.WriteLine("1. Calcular el factorial");
            Console.WriteLine("2. Calcular la raíz cuadrada");
            Console.WriteLine("3. Salir del programa");
            Console.Write("Ingrese un número entero positivo: ");

            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
            {
                Console.Write("Ingrese un número entero positivo válido: ");
            }

            Console.WriteLine();

            Console.Write("Ingrese su opción: ");
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3)
            {
                Console.Write("Ingrese una opción válida (1-3): ");
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"El factorial de {numero} es: {CalcularFactorial(numero)}");
                    break;
                case 2:
                    Console.WriteLine($"La raíz cuadrada de {numero} es: {Math.Sqrt(numero)}");
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 3);

        Console.WriteLine("\nFin del programa.");
    }

    static int CalcularFactorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * CalcularFactorial(n - 1);
    }
}
