using enerespaldo;
using monitoreo;
using simulacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine("3. Activar alarma manual (emergencia)");
                Console.WriteLine("4. Activar energia");
                Console.WriteLine("5. Activar energía de respaldo");
                Console.WriteLine("6. Simulación");
                Console.WriteLine("7. Salir");
                Console.ResetColor();
                Console.Write("\nSeleccione una opción: ");               
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: moni.toreo();  break;
                    case 2: MostrarHistorial(); break;
                    case 3: ActivarAlarmaManual(); break;
                    case 4: Energia(); break;
                    case 5: obj.respaldo(); break;
                    case 6: sensorsimulacion.ejecucion(); break;                       
                    case 7: Console.WriteLine("Saliendo del sistema..."); Console.Clear(); break;
                    default: Console.Clear(); Console.WriteLine("Opción no válida. Por favor, elija una opción del 1 al 4.");break;
                }
            } while (opcion != 7);
        }
        static List<string> HistorialEventos = new List<string>();
        static bool EnergiaPrincipal = true;
        static bool EnergiaRespaldo = false;
        static void MostrarHistorial()
        {
            Console.WriteLine("\n--- HISTORIAL DE EVENTOS ---");
            if (HistorialEventos.Count == 0)
                Console.WriteLine("No hay eventos registrados.");
            else
                HistorialEventos.ForEach(e => Console.WriteLine(e));
            Console.WriteLine("-----------------------------\n");
        }
        static void ActivarAlarmaManual()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n[ALARMA MANUAL ACTIVADA]");
            Console.ResetColor();;
            Console.WriteLine("Notificando a la central...");
            Console.WriteLine("Registrando evento manual...\n");

            HistorialEventos.Add($"{DateTime.Now} | Monitoreo en tiempo real activado por el operador");
        }
        static void Energia()
        {
            if ((new Random()).Next(0, 25) == 1 && EnergiaPrincipal)
            {
                EnergiaPrincipal = false;
                EnergiaRespaldo = true;
                Console.WriteLine("[ALERTA] Fallo de energía. Activando respaldo...\n");
                HistorialEventos.Add($"{(DateTime.Now)} | Energía de respaldo activada"); // Agregar al historial
            }
            else if (EnergiaRespaldo && (new Random()).Next(0, 10) == 1)
            {
                EnergiaPrincipal = true;
                EnergiaRespaldo = false;
                Console.WriteLine("[INFO] Energía principal restablecida.\n");
                HistorialEventos.Add($"{(DateTime.Now)} | Energía principal restablecida"); // Agregar al historial
            }
        }

    }
}
