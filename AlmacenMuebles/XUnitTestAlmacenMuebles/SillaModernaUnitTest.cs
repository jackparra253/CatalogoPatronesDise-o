using AlmacenMuebles.Dominio;
using Xunit;

namespace XUnitTestAlmacenMuebles
{
    public class SillaModernaUnitTest
    {
        [Fact(DisplayName = "Debe la SillaModerna ser de clase silla.")]
        public void Silla_Caso_ClaseSilla()
        {
            const string claseMuebleEsperado = ClasesMuebles.SILLA;

            SillaModerna silla = new SillaModerna(1);
            string claseMueble = silla.ObtenerClase();

            Assert.Equal(claseMuebleEsperado, claseMueble);
        }

        [Fact(DisplayName = "Debe la SillaModerna ser de tipo Moderna.")]
        public void Silla_Caso_TipoModerna()
        {
            const string tipoMuebleEsperada = ClasesMuebles.MODERNA;

            SillaModerna silla = new SillaModerna(2);
            string tipo = silla.ObtenerTipo();

            Assert.Equal(tipoMuebleEsperada, tipo);
        }

        [Fact(DisplayName = "Debe la Silla Moderna tener la cantidad de patas que le indiquen")]
        public void Silla_Caso_CantidadPatas()
        {
            var cantidadPatasEsperada = 3;

            SillaModerna silla = new SillaModerna(cantidadPatas: 3);
            int cantidadPatas = silla.ObtenerCantidadPatas();

            Assert.Equal(cantidadPatasEsperada, cantidadPatas);
        }
    }
}