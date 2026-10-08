using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_3_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int contadorOperaciones = 0;

            do
            {
                Console.WriteLine("\n==================================");
                Console.WriteLine("     CALCULADORA CON CICLOS       ");
                Console.WriteLine("==================================");
                Console.WriteLine("1) Suma");
                Console.WriteLine("2) Resta");
                Console.WriteLine("3) Multiplicación");
                Console.WriteLine("4) División");
                Console.WriteLine("5) Potencia (a^b)");
                Console.WriteLine("6) Tabla de multiplicar");
                Console.WriteLine("7) Salir");
                Console.WriteLine("==================================");
                Console.Write("Selecciona una opción: ");

                string entradaOpcion = Console.ReadLine();

                while (!int.TryParse(entradaOpcion, out opcion) || opcion < 1 || opcion > 7)
                {
                    Console.Write("Opción no válida. Ingresa un número entero del 1 al 7: ");
                    entradaOpcion = Console.ReadLine();
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\n SUMA ");
                        double numS1 = LeerNumero("Ingresa el primer número: ");
                        double numS2 = LeerNumero("Ingresa el segundo número: ");
                        Console.WriteLine($"Resultado: {numS1} + {numS2} = {numS1 + numS2}");
                        contadorOperaciones++;
                        break;

                    case 2:
                        Console.WriteLine("\n RESTA ");
                        double numR1 = LeerNumero("Ingresa el primer número: ");
                        double numR2 = LeerNumero("Ingresa el segundo número: ");
                        Console.WriteLine($"Resultado: {numR1} - {numR2} = {numR1 - numR2}");
                        contadorOperaciones++;
                        break;

                    case 3:
                        Console.WriteLine("\n MULTIPLICACIÓN ");
                        double numM1 = LeerNumero("Ingresa el primer número: ");
                        double numM2 = LeerNumero("Ingresa el segundo número: ");
                        Console.WriteLine($"Resultado: {numM1} * {numM2} = {numM1 * numM2}");
                        contadorOperaciones++;
                        break;

                    case 4:
                        Console.WriteLine("\n DIVISIÓN ");
                        double numD1 = LeerNumero("Ingresa el dividendo: ");
                        double numD2 = LeerNumero("Ingresa el divisor: ");

                        if (numD2 == 0)
                        {
                            Console.WriteLine("Error: No se puede dividir entre 0.");
                        }
                        else
                        {
                            Console.WriteLine($"Resultado: {numD1} / {numD2} = {numD1 / numD2}");
                            contadorOperaciones++;
                        }
                        break;

                    case 5:
                        Console.WriteLine("\n POTENCIA (a^b) ");
                        double baseNum = LeerNumero("Ingresa la base (a): ");
                        int exponente = LeerEnteroNoNegativo("Ingresa el exponente (b, entero >= 0): ");

                        double resultadoPotencia = 1;
                        for (int i = 0; i < exponente; i++)
                        {
                            resultadoPotencia *= baseNum;
                        }

                        Console.WriteLine($"Resultado: {baseNum}^{exponente} = {resultadoPotencia}");
                        contadorOperaciones++;
                        break;

                    case 6:
                        Console.WriteLine("\n TABLA DE MULTIPLICAR ");
                        double numTabla = LeerNumero("Ingresa el número para ver su tabla: ");

                        Console.WriteLine($"\nTabla de multiplicar del {numTabla}:");
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine($"{numTabla} x {i} = {numTabla * i}");
                        }
                        contadorOperaciones++;
                        break;

                    case 7:
                        Console.WriteLine($"\nHiciste {contadorOperaciones} operaciones.");
                        Console.WriteLine("¡Gracias por usar la calculadora!");
                        break;
                }

            } while (opcion != 7);
        }

        static double LeerNumero(string mensaje)
        {
            double numero;
            Console.Write(mensaje);
            string entrada = Console.ReadLine();

            while (!double.TryParse(entrada, out numero))
            {
                Console.Write("Entrada no válida. Escribe un número: ");
                entrada = Console.ReadLine();
            }

            return numero;
        }

        static int LeerEnteroNoNegativo(string mensaje)
        {
            int numero;
            Console.Write(mensaje);
            string entrada = Console.ReadLine();

            while (!int.TryParse(entrada, out numero) || numero < 0)
            {
                Console.Write("Entrada no válida. Ingresa un entero mayor o igual a 0: ");
                entrada = Console.ReadLine();
            }

            return numero;
        }
    }
    }

