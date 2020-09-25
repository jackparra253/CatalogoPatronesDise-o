namespace AlmacenMuebles.Dominio
{
    public class MesaCentroModerna : IMesaCentro
    {
        public MesaCentroModerna()
        {
            Clase = ClasesMuebles.MESACENTRO;
            Tipo = ClasesMuebles.MODERNA;
        }

        public string Clase { get; private set; }
        public string Tipo { get; private set; }
    }
}
