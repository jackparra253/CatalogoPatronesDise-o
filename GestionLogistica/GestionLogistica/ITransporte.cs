namespace GestionLogistica
{
    ////ITransporte
    //// The Product interface declares the operations that all concrete products
    //// must implement.

    public interface ITransporte
    {
        bool Entregar(bool entregado);
        string ObtenerTipo();
    }
}