using GestionLogistica;
using Xunit;

namespace Test
{
    public class BarcoTest
    {
        [Fact(DisplayName = "Debe Entregar retornar true cuando realiza la entrega")]

        public void Entragar_Caso_Entregado()
        {
            var barco = CrearBarco();

            bool entregado = barco.Entregar(true);

            Assert.True(entregado);
        }

        [Fact(DisplayName = "Debe Entregar retornar falso cuando no realiza la entrega")]

        public void Entragar_Caso_NoEntregado()
        {
            var barco = CrearBarco();

            bool entregado = barco.Entregar(false);

            Assert.False(entregado);
        }

        private Barco CrearBarco()
        {
            return new Barco(true);
        }
    }
}
