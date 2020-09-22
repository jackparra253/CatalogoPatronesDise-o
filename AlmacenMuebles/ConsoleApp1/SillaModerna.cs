namespace AlmacenMuebles.Dominio
{
    public class SillaModerna
    {
        public SillaModerna(int cantidadPatas)
        {
            Clase = ClasesMuebles.SILLA;
            Tipo = ClasesMuebles.MODERNA;
            CantidadPatas = cantidadPatas;
        }

        public string Clase { get; private set; }
        public string Tipo { get; private set; }
        public int CantidadPatas { get; private set; }

        public string ObtenerClase()
        {
            return Clase;
        }

        public string ObtenerTipo()
        {
            return Tipo;
        }

        public int ObtenerCantidadPatas()
        {
            return CantidadPatas;
        }
    }
}