using System;
using static System.Console;

namespace Gasolinera_Kinal.Util
{
    public static class Printer
    {
        public static void Beep(int hz = 3000, int tiempo = 500, int cantidad = 1)
        {
            while(cantidad-- > 0)
            {
                Console.Beep(hz, tiempo);
            }
        }

        public static void WriteTitle(string title)
        {
            var tamaño = title.Length + 4;
            DrawLine(tamaño);
            WriteLine($"| {title} |"); //Interpolación
            DrawLine(tamaño);
        }

        public static void DrawLine(int size = 10)
        {
            WriteLine("".PadLeft(size, '='));
        }

        public static void PresionarEnter()
        {
            WriteLine("Presionar enter para continuar");
            ReadLine();
        }
    }
}