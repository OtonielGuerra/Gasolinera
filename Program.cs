using System;
using Gasolinera_Kinal.Controllers;
using Gasolinera_Kinal.Entities;
using Gasolinera_Kinal.Menu;
using static Gasolinera_Kinal.Util.Printer;

namespace Gasolinera_Kinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Beep();
            WriteTitle("Gasolinera Kinal!!!");

            new MenuPrincipal().MostrarMenu();
            // string salida = "Gasolinera_Kinal.Entities.Super";

            // Console.WriteLine($"split {salida.Split(".")[2]}");
            
            // Console.WriteLine($"IndexLast {salida.Substring(salida.LastIndexOf(".") + 1)}");

            // for (int i = salida.Length - 1; i >= 0; i--)
            // {
            //     if (salida.Substring(i,1).Equals("."))
            //     {
            //         Console.WriteLine(salida.Substring(i + 1, salida.Length - i - 1));
            //         break;
            //     }
            // }
            PresionarEnter();
        }
    }
}
