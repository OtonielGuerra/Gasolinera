using System;
using System.Collections.Generic;
using Gasolinera_Kinal.Entities;
using Gasolinera_Kinal.Interfaces;
using static Gasolinera_Kinal.Util.Printer;
using static System.Console;

namespace Gasolinera_Kinal.Controllers
{
    public class GasolineraController : IMantenimiento
    {
        private List<Bomba> ListaDeBombas = new List<Bomba>();

        public void agregar(object elemento)
        {
            this.ListaDeBombas.Add((Bomba)elemento);
        }

        public object buscar(string id)
        {
            Bomba resultado = null;
            foreach(var item in ListaDeBombas)
            {
                if(item.Id.Equals(id, StringComparison.Ordinal))
                {
                    resultado = item;
                    break;
                }
            }
            return (object)resultado;
        }

        public void eliminar(object elemento)
        {
            this.ListaDeBombas.Remove((Bomba)elemento);
        }

        public void listar()
        {
            WriteTitle("Listado de bombas de gasolina");
            foreach (var item in ListaDeBombas)
            {
                WriteLine(item);
            }
        }

        public void modificar(object elemento)
        {
            
        }
    }
}