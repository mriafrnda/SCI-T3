using enerespaldo;
using monitoreo;
using simulacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using historialeventos;

namespace ultimoProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            eneres obj = new eneres();
            int opcion;                     
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("=========================================");
                Console.WriteLine("         SISTEMA CONTRA INCENDIOS ");
                Console.WriteLine("=========================================");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("1. Iniciar monitoreo");
                Console.WriteLine("2. Mostrar historial de eventos");
                Console.WriteLine("3. Activar energía de respaldo");
                Console.WriteLine("4. Simulación");
                Console.WriteLine("5. Salir");
                Console.ResetColor();
                Console.Write("\nSeleccione una opción: ");               
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: moni.toreo();  break;
                    case 2: hist.Mostrar(); break;
                    case 3: obj.respaldo(); break;
                    case 4: sensorsimulacion.ejecucion(); break;                       
                    case 5: Console.WriteLine("Saliendo del sistema..."); Console.Clear(); break;
                    default: Console.Clear(); Console.WriteLine("Opción no válida. Por favor, elija una opción del 1 al 4.");break;
                }
            } while (opcion != 5);
        }
       
    }
}
