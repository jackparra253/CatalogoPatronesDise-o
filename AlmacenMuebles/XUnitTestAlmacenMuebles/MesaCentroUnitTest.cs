using AlmacenMuebles.Dominio;
using Xunit;

namespace XUnitTestAlmacenMuebles
{
    public class MesaCentroUnitTest
    {
        [Fact(DisplayName = "La MesaCentroModerna debe ser de Clase MesaCentro")]
        public void MesaCentroModerna_Caso_Clase_MesaCentro()
        {
            MesaCentroModerna mesaCentroModerna = new MesaCentroModerna();            

            Assert.Equal(ClasesMuebles.MESACENTRO, mesaCentroModerna.Clase);
        }

        [Fact(DisplayName = "La MesaCentroModerna debe ser de Tipo Moderna")]
        public void MesaCentroModerna_Caso_Tipo_Moderna()
        {
            MesaCentroModerna mesaCentroModerna = new MesaCentroModerna();
            string tipoMesaCentro = mesaCentroModerna.Tipo;

            Assert.Equal(ClasesMuebles.MODERNA, tipoMesaCentro);
        }
    }
}
