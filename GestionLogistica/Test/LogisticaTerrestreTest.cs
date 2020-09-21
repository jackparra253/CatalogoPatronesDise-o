using GestionLogistica;
using Xunit;

namespace Test
{
    public class LogisticaTerrestreTest
    {
        [Fact(DisplayName = "debe CrearTransporte crear un Caminon")]
        public void CrearTransporte_Caso_CrearCamion()
        {
            LogisticaTerrestre logisticaTerrestre = new LogisticaTerrestre();

            ITransporte camion = logisticaTerrestre.CrearTransporte(true);
            string tipo = camion.ObtenerTipo();

            Assert.Equal(TipoLogistica.Camion, tipo);
        }
    }
}
