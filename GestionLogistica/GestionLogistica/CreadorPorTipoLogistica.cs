using System;

namespace GestionLogistica
{
    //abstract class Creator
    //{
    //    // Note that the Creator may also provide some default implementation of
    //    // the factory method.
    //    public abstract IProduct FactoryMethod();

    //    // Also note that, despite its name, the Creator's primary
    //    // responsibility is not creating products. Usually, it contains some
    //    // core business logic that relies on Product objects, returned by the
    //    // factory method. Subclasses can indirectly change that business logic
    //    // by overriding the factory method and returning a different type of
    //    // product from it.
    //    public string SomeOperation()
    //    {
    //        // Call the factory method to create a Product object.
    //        var product = FactoryMethod();
    //        // Now, use the product.
    //        var result = "Creator: The same creator's code has just worked with "
    //            + product.Operation();

    //        return result;
    //    }
    //}


    class CreadorPorTipoLogistica
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
           Crear(new LogisticaTerrestre());


            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            Crear(new LogisticaMaritima());
        }

        // The client code works with an instance of a concrete creator, albeit
        // through its base interface. As long as the client keeps working with
        // the creator via the base interface, you can pass it any creator's
        // subclass.
        public void Crear(Logistica logistica)
        {
            ITransporte transporte = logistica.CrearTransporte(true);
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + transporte);
            Console.ReadLine();         
        }
    }
}
