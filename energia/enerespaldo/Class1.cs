using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace enerespaldo
{
    public class eneres
    {
        public void respaldo ()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Advertencia: El sistema de energía principal ha fallado.");
            Console.ResetColor();
            Console.WriteLine("Activando sistema de energía de respaldo...");
            Thread.Sleep(2000);
            Console.WriteLine("Sistema de energía de respaldo activado.");
            Console.WriteLine("");
            Console.WriteLine("Nivel de energia: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***--***");
            Console.WriteLine("*      *");
            Console.Write("* 100% *   ");
            Console.ResetColor();
            Console.WriteLine("-->   48 horas de uso");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*      *");
            Console.WriteLine("********");
            Console.WriteLine("");
            Console.ResetColor();
            Console.WriteLine("Saliendo del programa...");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
