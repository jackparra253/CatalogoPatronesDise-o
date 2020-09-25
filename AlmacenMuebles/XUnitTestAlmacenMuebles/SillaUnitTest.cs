using AlmacenMuebles.Dominio;
using Xunit;

namespace XUnitTestAlmacenMuebles
{
    public class SillaUnitTest
    {
        [Fact(DisplayName = "La SillaModerna debe ser de clase silla.")]
        public void SillaModerna_Caso_ClaseSilla()
        {
            ISilla sillaModerna = new SillaModerna(cantidadPatas: 1);
            string claseMueble = sillaModerna.Clase;

            Assert.Equal(ClasesMuebles.SILLA, claseMueble);
        }

        [Fact(DisplayName = "La SillaModerna debe ser de tipo Moderna.")]
        public void SillaModerna_Caso_TipoModerna()
        {
            ISilla sillaModerna = new SillaModerna(cantidadPatas: 2);
            string tipo = sillaModerna.Tipo;

            Assert.Equal(ClasesMuebles.MODERNA, tipo);
        }

        [Fact(DisplayName = "La SillaModerna debe tener la cantidad de patas que le indiquen.")]
        public void SillaModerna_Caso_CantidadPatas()
        {
            var cantidadPatasEsperada = 3;

            ISilla sillaModerna = new SillaModerna(cantidadPatas: 3);
            int cantidadPatas = sillaModerna.CantidadPatas;

            Assert.Equal(cantidadPatasEsperada, cantidadPatas);
        }

        [Fact(DisplayName = "La SillaModerna debe reponder si TienePatas")]
        public void SillaModerna_Caso_TienePatas()
        {
            ISilla sillaModerna = new SillaModerna(2);
            bool tienePatas = sillaModerna.TienePatas();

            Assert.True(tienePatas);
        }

        [Fact(DisplayName = "La SillaModerna debe responder False si la cantidad de patas en 0")]
        public void SillaModerna_Caso_No_TienePatas()
        {
            ISilla sillaModerna = new SillaModerna(0);
            bool tienePatas = sillaModerna.TienePatas();

            Assert.False(tienePatas);
        }

        [Fact(DisplayName = "La SillaVictoriana debe ser clase Silla.")]
        public void SillaVictoriana_Caso_Clase_Silla()
        {
            ISilla sillaVictoriana = new SillaVictoriana();
            string claseMueble = sillaVictoriana.Clase;

            Assert.Equal(ClasesMuebles.SILLA, claseMueble);
        }

        [Fact(DisplayName = "La SillaVictoriana debe ser de Tipo Victoriana.")]
        public void SillaVictoriana_Caso_Tipo_Vitoriana()
        {
            ISilla sillaVictoriana = new SillaVictoriana();
            string tipoMueble = sillaVictoriana.Tipo;

            Assert.Equal(ClasesMuebles.VICTORIANA, tipoMueble);
        }

        [Fact(DisplayName = "La SillaVictoriana debe tener CantidadPatas 4")]
        public void SillaVictoriana_Caso_CantidadPatas_4()
        {
            const int cantidadPatasEsperada = 4;

            ISilla sillaVictoriana = new SillaVictoriana();
            int cantidadPatas = sillaVictoriana.CantidadPatas;

            Assert.Equal(cantidadPatasEsperada, cantidadPatas);
        }

        [Fact(DisplayName ="La SillaVictoriana debe responder siempre true TienePatas ")]
        public void SillaVictoriana_Caso_TienePatas()
        {
            ISilla sillaVictoriana = new SillaVictoriana();
            bool tienePatas = sillaVictoriana.TienePatas();

            Assert.True(tienePatas);
        }
    }
}