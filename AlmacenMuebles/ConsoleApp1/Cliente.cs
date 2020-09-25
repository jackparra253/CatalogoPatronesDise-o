using System;

namespace AlmacenMuebles.Dominio
{
    public class Cliente
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new MobiliarioModerno());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new MobiliarioVictoriano());
        }

        public void ClientMethod(IMobiliario mobiliario)
        {
            var mesaCentro = mobiliario.CrearMesaCentro();
            var silla = mobiliario.CrearSilla();

            Console.WriteLine(mesaCentro.Clase);
            Console.WriteLine(mesaCentro.Tipo);
            Console.WriteLine(silla.Clase);
            Console.WriteLine(silla.Tipo);
        }
    }
}