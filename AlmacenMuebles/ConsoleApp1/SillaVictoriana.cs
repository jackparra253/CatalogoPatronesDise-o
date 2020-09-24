namespace AlmacenMuebles.Dominio
{
    public class SillaVictoriana: ISilla
    {
        public SillaVictoriana()
        {
            Clase = ClasesMuebles.SILLA;
            Tipo = ClasesMuebles.VICTORIANA;
            CantidadPatas = 4;
        }

        public string Clase { get; private set; }
        public string Tipo { get; private set; }
        public int CantidadPatas { get; private set; }

        public int ObtenerCantidadPatas()
        {
            return CantidadPatas;
        }

        public string ObtenerClase()
        {
            return Clase;
        }

        public string ObtenerTipo()
        {
            return Tipo;
        }
    }
}