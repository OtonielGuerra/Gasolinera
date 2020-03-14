using static Gasolinera_Kinal.Util.Printer;
using static System.Console;
using System;
using Gasolinera_Kinal.Controllers;
using Gasolinera_Kinal.Entities;

namespace Gasolinera_Kinal.Menu
{
    public class MenuPrincipal
    {
        private GasolineraController controller = new GasolineraController();
        public void MostrarMenu()
        {
            try
            {
                byte opcion = 0;
                do
                {
                    Clear();
                    WriteTitle("Administrar Bombas");
                    WriteLine("1. Agregar");
                    WriteLine("2. Eliminar");
                    WriteLine("3. Buscar");
                    WriteLine("4. Listar");
                    WriteLine("5. Modificar");
                    WriteLine("0. Salir");
                    WriteLine("Ingrese una opción");
                    string respuesta = ReadLine();
                    opcion = Convert.ToByte(respuesta);
                    switch(opcion)
                    {
                        case 1:
                            AgregarTipoBomba();
                            break;
                        case 2:
                            Eliminar();
                            break;
                        case 3:
                            BuscarID();
                            break;
                        case 4:
                            ListarBombas();
                            break;
                        case 5:
                            Modificar();
                            break;
                        case 0:
                            break;
                        default:
                            WriteLine("No existe la opción");
                            break;
                    }
                }while(opcion != 0);
            }
            catch(Exception e)
            {
                WriteLine(e.Message);
            }
        }
        #region Agregar Tipo Bomba
        private void AgregarTipoBomba()
        {
            byte opcion = 0;
            WriteTitle("Tipo de Bomba");
            WriteLine("1. Súper");
            WriteLine("2. Regular");
            WriteLine("3. Diesel");
            WriteLine("0. Salir");
            WriteLine("Seleccione una opción ==> ");
            string respuesta = ReadLine();
            if(respuesta.Equals("1"))
            {
                Bomba super = new Super();
                AgregarElemento(super);

            }else if(respuesta.Equals("2"))
            {
                Bomba regular = new Regular();
                AgregarElemento(regular);
            }else if(respuesta.Equals("3"))
            {
                Bomba diesel = new Diesel();
                AgregarElemento(diesel);
            }
        }
        #endregion

        private void AgregarElemento(Bomba elemento)
        {
            WriteLine("Ingrese un precio");
            elemento.Precio = Convert.ToDouble(ReadLine());
            WriteLine("Ingrese una capacidad");
            elemento.Capacidad = Convert.ToInt16(ReadLine());
            WriteLine("Ingrese una medida");
            elemento.Medida = ReadLine();
            //En vez de ejecutar esta instrucción cada vez que termina el método, se ejecutan los if
            if(elemento.GetType() == typeof(Super))
            {
                WriteLine("Ingrese numero de aditivos");
                ((Super)elemento).Aditivo = Convert.ToInt16(ReadLine());
            }else if(elemento.GetType() == typeof(Diesel))
            {
                WriteLine("Ingrese formula");
                ((Diesel)elemento).Formula = ReadLine();
            }
            controller.agregar(elemento);
        }

        private void ListarBombas()
        {
            controller.listar();
            PresionarEnter();
        }

        private void Eliminar()
        {
            controller.listar();
            WriteLine("Ingrese el id a eliminar");
            string id = Console.ReadLine();
            object elemento = buscar(id);
            if (elemento != null)
            {
                WriteLine("Esta seguro de querer eliminar S/N");
                string resultado = Console.ReadLine();
                if (resultado.Equals("s"))
                {
                    controller.eliminar(elemento);
                    WriteLine("Registro Eliminado");
                    ReadKey();
                }
            }
        }

        private object buscar(string id)
        {
            return controller.buscar(id);
        }

        private void BuscarID()
        {
            controller.listar();
            WriteLine("Ingrese el id");
            string res = ReadLine();
            object elemento = controller.buscar(res);
            
            if (elemento != null)
            {
                WriteLine(elemento);
            }
            else
            {
                WriteLine("No existe");
            }
            ReadKey();
        }

        public void Modificar()
        {
            controller.listar();
            WriteLine("Ingrese el id");
            string res = ReadLine();
            object element = buscar(res);
            if (element != null)
            {
                ((Bomba)element).Capacidad = 2020;
            }
            else
            {
                WriteLine($"No existe este elemento: {res}");
            }
            ReadKey();
        }
    }
}