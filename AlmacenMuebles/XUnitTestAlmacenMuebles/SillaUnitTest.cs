using AlmacenMuebles.Dominio;
using Xunit;

namespace XUnitTestAlmacenMuebles
{
    public class SillaUnitTest
    {
        [Fact(DisplayName = "Debe la SillaModerna ser de clase silla.")]
        public void SillaModerna_Caso_ClaseSilla()
        {
            const string claseMuebleEsperado = ClasesMuebles.SILLA;

            ISilla sillaModerna = new SillaModerna(1);
            string claseMueble = sillaModerna.ObtenerClase();

            Assert.Equal(claseMuebleEsperado, sillaModerna.Clase);
        }

        [Fact(DisplayName = "Debe la SillaModerna ser de tipo Moderna.")]
        public void SillaModerna_Caso_TipoModerna()
        {
            const string tipoMuebleEsperada = ClasesMuebles.MODERNA;

            ISilla sillaModerna = new SillaModerna(2);
            string tipo = sillaModerna.ObtenerTipo();

            Assert.Equal(tipoMuebleEsperada, tipo);
        }

        [Fact(DisplayName = "Debe la Silla Moderna tener la cantidad de patas que le indiquen")]
        public void SillaModerna_Caso_CantidadPatas()
        {
            var cantidadPatasEsperada = 3;

            ISilla sillaModerna = new SillaModerna(cantidadPatas: 3);
            int cantidadPatas = sillaModerna.ObtenerCantidadPatas();

            Assert.Equal(cantidadPatasEsperada, cantidadPatas);
        }

        [Fact(DisplayName = "Debe SillaVictoriana ser clase Silla")]
        public void SillaVictoriana_Caso_ClaseSilla()
        {
            const string claseMuebleEsperado = ClasesMuebles.SILLA;

            ISilla sillaVictoriana = new SillaVictoriana();
            string claseMueble = sillaVictoriana.ObtenerClase();

            Assert.Equal(claseMuebleEsperado, claseMueble);
        }

        [Fact(DisplayName = "La SillaVictoriana debe ser de Tipo Victoriana")]
        public void SillaVictoriana_Caso_Vitoriana()
        {
            const string tipoMuebleEsperado = ClasesMuebles.VICTORIANA;

            ISilla sillaVictoriana = new SillaVictoriana();
            string tipoMueble = sillaVictoriana.ObtenerTipo();

            Assert.Equal(tipoMuebleEsperado, tipoMueble);
        }

        [Fact(DisplayName = "La SillaVictoriana debe tener CantidadPatas 4")]
        public void SillaVictoriana_Caso_CantidadPatas_4()
        {
            const int cantidadPatasEsperada = 4;

            ISilla sillaVictoriana = new SillaVictoriana();
            int cantidadPatas = sillaVictoriana.ObtenerCantidadPatas();

            Assert.Equal(cantidadPatasEsperada, cantidadPatas);
        }
    }
}