namespace GestionLogistica
{
    //// Concrete Creators override the factory method in order to change the
    //// resulting product's type.

    public class LogisticaTerrestre: Logistica
    {
        public override ITransporte CrearTransporte(bool estado)
        {
            return new Camion(estado);
        }
    }

}