using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using alarma;
namespace monitoreo
{
    public class moni
    {
        public static void toreo()
        {
            Console.Clear();
            int numsensores = 0;
            Random num = new Random();
            float[] sensores = new float[5];
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < sensores.Length; i++)
                {
                    sensores[i] = num.Next(25, 36);
                    string sensortemp = "sensor de temperatura " + (i + 1);
                    string sensorhumo = "sensor de humo " + (i + 1);
                    Console.WriteLine("|" + sensortemp + ": " + sensores[i] + "°          | " + sensorhumo + ": " + sensores[i] + "°           |");
                    Console.WriteLine("|                                      |                                 |");
                    if (sensores[i] > 57)
                    {
                        sonido.alarma();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("|¡PELIGRO! en " + sensortemp + "  |  ¡PELIGRO! en " + sensorhumo + "  |");
                        numsensores++;
                        Console.ResetColor();
                        Console.WriteLine("--------------------------------------------------------------------------");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("|No se detectó ningún incendio         |  No se detectó ningún incendio  |");
                        Console.ResetColor();
                        Console.WriteLine("--------------------------------------------------------------------------");
                    }
                    Console.ResetColor();
                }
                Console.WriteLine("\nPresione ENTER para salir del monitoreo...");
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    break;
                }
                Thread.Sleep(1000);
                if (numsensores > 3) { break; }
            } 
            if (numsensores >= 3) { Console.WriteLine("LLAMANDO A UN TECNICO"); Console.ReadKey(); }
            else
            {
                Console.WriteLine("Confirmación para llamar a un tecnico");
                Console.Write("(1)Sí (2)No :");
                int opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("LLAMANDO A UN TECNICO");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("LLAMADA CANCELADA "); Console.ReadKey(); Console.Clear();
                }
                else Console.WriteLine("Opción no válida");
            }
        }
    }
}
