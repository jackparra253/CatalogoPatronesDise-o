namespace AlmacenMuebles.Dominio
{
    internal class MobiliarioModerno : IMobiliario
    {
        public IMesaCentro CrearMesaCentro()
        {
            return new MesaCentroModerna();
        }

        public ISilla CrearSilla()
        {
            return new SillaModerna(3);
        }
    }
}