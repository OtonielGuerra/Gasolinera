namespace Gasolinera_Kinal.Interfaces
{
    public interface IControlBomba
    {
        void despachar(int cantidad);
        int VerNivelCapacidad();
    }
}