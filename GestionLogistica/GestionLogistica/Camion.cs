namespace GestionLogistica
{
    public class Camion: ITransporte
    {
        public Camion()
        {
        }

        public bool Entregar(bool recibido)
        {
            return recibido;
        }
    }
}