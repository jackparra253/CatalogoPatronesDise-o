namespace AlmacenMuebles.Dominio
{
    internal class MobiliarioVictoriano : IMobiliario
    {
        public IMesaCentro CrearMesaCentro()
        {
            return new MesaCentroVictoriana();
        }

        public ISilla CrearSilla()
        {
            return new SillaVictoriana();
        }
    }
}