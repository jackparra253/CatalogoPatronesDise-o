namespace AlmacenMuebles.Dominio
{
    public interface ISilla
    {
        int CantidadPatas { get; }
        string Clase { get; }
        string Tipo { get; }
        bool TienePatas();
    }
}