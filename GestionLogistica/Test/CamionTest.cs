using GestionLogistica;
using Xunit;

namespace Test
{
    public class CamionTest
    {        
        [Fact(DisplayName = "Debe Entregar retornar true cuando realiza la entrega")]

        public void Entragar_Caso_Entregado()
        {
            var camion = CrearCamion();

            bool entregado = camion.Entregar(true);

            Assert.True(entregado);
        }

        [Fact(DisplayName = "Debe Entregar retornar falso cuando no realiza la entrega")]

        public void Entragar_Caso_NoEntregado()
        {
            var camion = CrearCamion();

            bool entregado = camion.Entregar(false);

            Assert.False(entregado);
        }

        private Camion CrearCamion()
        {
            return new Camion();
        }
    }
}
