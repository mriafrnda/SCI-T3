using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using alarma;
using historialeventos;
namespace simulacion
{
    public class sensorsimulacion
    {
        public static void ejecucion()
        {
            Console.Clear();
            int numsensores = 0;
            Random num = new Random();
            float[] sensores = new float[5];

            for (int i = 0; i < sensores.Length; i++)
            {
                sensores[i] = num.Next(56, 100);
                float porsentajehumo = (float)(num.NextDouble()*10);
                string sensortemp = "sensor de temperatura " + (i + 1);
                string sensorhumo = "sensor de humo " + (i + 1);

                Console.WriteLine("|" + sensortemp + ": " + sensores[i] + "°          | " + sensorhumo + ": " + porsentajehumo.ToString("0.0") + "%          |");
                Console.WriteLine("|                                      |                                 |");

                if (sensores[i] > 57 && porsentajehumo > 2.5)
                {
                    sonido.alarma();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("|¡PELIGRO! en " + sensortemp + "  |  ¡PELIGRO! en " + sensorhumo + "  |");
                    numsensores++;
                    Console.ResetColor();
                    Console.WriteLine("--------------------------------------------------------------------------");
                }
                else if (sensores[i] > 57 || porsentajehumo < 2.5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("|¡PELIGRO! en " + sensortemp);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("  |  No se detectó ningún incendio  |");
                    Console.ResetColor();
                    Console.WriteLine("--------------------------------------------------------------------------");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("| No se detectó ningún incendio     |  No se detectó ningún incendio  |");
                    Console.ResetColor();
                    Console.WriteLine("--------------------------------------------------------------------------");
                }
                Console.ResetColor();
            }

            if (numsensores >= 3)
            {
                Console.WriteLine("LLAMANDO A LOS BOMBEROS");
                Thread.Sleep(5000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Confirmación para llamar a los bomberos");
                Console.WriteLine("(1)Sí (2)No");
                int opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("LLAMANDO A LOS BOMBEROS");
                    Thread.Sleep(5000);
                    Console.Clear();
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("No se llamará a los bomberos");
                    Thread.Sleep(5000);
                    Console.Clear();
                }
                else
                    Console.WriteLine("Opción no válida");
        
            }
            hist.Registrar("Se detecto una insendio en simulacion a las:");          
        }
    }
}
