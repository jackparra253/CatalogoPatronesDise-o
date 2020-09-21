﻿namespace GestionLogistica
{
    //// The Creator class declares the factory method that is supposed to return
    //// an object of a Product class. The Creator's subclasses usually provide
    //// the implementation of this method.
    public abstract class Logistica
    {
        public abstract ITransporte CrearTransporte(bool estado);
    }
}
