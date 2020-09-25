namespace AlmacenMuebles.Dominio
{
    public class MesaCentroVictoriana : IMesaCentro
    {
        public MesaCentroVictoriana()
        {
            Clase = ClasesMuebles.MESACENTRO;
            Tipo = ClasesMuebles.VICTORIANA;
        }

        public string Clase { get; private set; }

        public string Tipo { get; private set; }
    }
}