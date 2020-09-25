namespace AlmacenMuebles.Dominio
{
    public class SillaModerna : ISilla
    {
        public SillaModerna()
        {
        }

        public SillaModerna(int cantidadPatas)
        {
            Clase = ClasesMuebles.SILLA;
            Tipo = ClasesMuebles.MODERNA;
            CantidadPatas = cantidadPatas;
        }

        public string Clase { get; private set; }
        public string Tipo { get; private set; }
        public int CantidadPatas { get; private set; }

        public bool TienePatas()
        {
            return CantidadPatas > 0;
        }
    }
}