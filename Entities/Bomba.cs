using System;
using Gasolinera_Kinal.Interfaces;

namespace Gasolinera_Kinal.Entities
{
    public abstract class Bomba : IControlBomba
    {
        public Bomba()
        {
            this.Id = GenerarID();
        }
        public Bomba(double precio, int capacidad, string medida)
        {
            this.Id = GenerarID();
            this.Precio = precio;
            this.Capacidad = capacidad;
            this.Medida = medida;
        }
        public string Id { get; set; }
        public double Precio { get; set; }
        public int Capacidad { get; set; }
        public string Medida { get; set; }

        public void despachar(int cantidad)
        {
            if(this.Capacidad >= cantidad)
            {
                this.Capacidad -= cantidad;
            }
        }

        public int VerNivelCapacidad()
        {
            return this.Capacidad;
        }

        //public abstract void despachar(int cantidad);
        //public abstract int VerNivelCapacidad();

        private string GenerarID()
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }

        public override string ToString()
        {
            return $"{{\"Id\" : \"{this.Id}\", \"Capacidad\" : \"{this.Capacidad}\", \"Tipo\" : \"{this.GetType().ToString().Substring(this.GetType().ToString().LastIndexOf(".") + 1)}\"}}";
        }
    }
}