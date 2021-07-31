using System;

namespace Primer_proyecto_de_consola_en_Visual_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0;

            Console.WriteLine("calculadora en consola en C#\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("escriba un numero y presione enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" escriba un numero y presione enter");
            num2 = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("eliga una opcion:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("su opcion? ");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($" tu resultado de {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($" tu resltado de {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"el resultado de {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"el resultador de {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Wait for the user to respond before closing.
            Console.Write("presione cualquier boton para cerrar la app...");
            Console.ReadKey();

        }

    }
}
