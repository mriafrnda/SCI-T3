using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace historialeventos
{
    public static class hist
    {
        private static List<string> eventos = new List<string>();

        public static void Registrar(string descripcion)
        {
            eventos.Add($"{descripcion} - {DateTime.Now:HH:mm:ss} ");
        }

        public static void Mostrar()
        {
            Console.Clear();
            Console.WriteLine("\n--- HISTORIAL DE EVENTOS ---");
            if (eventos.Count == 0)
                Console.WriteLine("No hay eventos registrados.");
            else
                Console.ForegroundColor = ConsoleColor.Magenta;
                eventos.ForEach(e => Console.WriteLine(e));
            Console.ResetColor();
            Console.WriteLine("-----------------------------\n"); Thread.Sleep(4000); Console.Clear();
        }
    }
}
