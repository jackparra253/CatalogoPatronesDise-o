namespace GestionLogistica
{
    //// Concrete Products provide various implementations of the Product
    //// interface.
    public class Barco : ITransporte
    {
        private Barco () { }

        public Barco(bool estado)
        {
            Tipo = TipoLogistica.Barco;
            Estado = estado;
        }

        public string Tipo { get; private set; }
        public bool Estado { get; private set; }

        public bool Entregar(bool entregado)
        {
            return entregado;
        }

        public string ObtenerTipo()
        {
            return Tipo;
        }
    }
}