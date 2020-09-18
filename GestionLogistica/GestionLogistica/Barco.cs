namespace GestionLogistica
{
    public class Barco : ITransporte
    {
        public Barco()
        {
        }

        public bool Entregar(bool entregado)
        {
            return entregado;
        }
    }
}