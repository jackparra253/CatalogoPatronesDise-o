namespace GestionLogistica
{
    //// Concrete Products provide various implementations of the Product
    //// interface.
    public class Camion: ITransporte
    {
        private Camion() { }

        public Camion(bool estado)
        {
            Tipo = TipoLogistica.Camion;
            Estado = estado;
        }

        public string Tipo { get; private set; }
        public bool Estado { get; private set; }

        public bool Entregar(bool recibido)
        {
            return recibido;
        }

        public string ObtenerTipo()
        {
            return Tipo;
        }
    }
}