namespace GestionLogistica
{
    ////LogisticaTerrestre
    //// Concrete Creators override the factory method in order to change the
    //// resulting product's type.

    public class LogisticaMaritima: Logistica
    {
        public override ITransporte CrearTransporte(bool estado)
        {
            return new Barco(estado);
        }
    }
}