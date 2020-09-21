using GestionLogistica;
using Xunit;

namespace Test
{
    public class LogisticaMaritimaTest
    {
        [Fact(DisplayName = "debe CrearTransporte crear un Barco")]
        public void CrearTransporte_Caso_CrearBarco()
        {
            LogisticaMaritima logisticaTerrestre = new LogisticaMaritima();

            ITransporte barco = logisticaTerrestre.CrearTransporte(true);
            string tipo = barco.ObtenerTipo();

            Assert.Equal(TipoLogistica.Barco, tipo);
        }
    }
}
