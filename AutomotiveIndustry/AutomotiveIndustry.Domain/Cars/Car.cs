using System;
using System.Collections.Generic;
using System.Text;

namespace AutomotiveIndustry.Domain.Cars
{
    public class Car
    {
        public TYPE Type { get; private set; }
        public int Seats { get; private set; }
        public Engine Engine { get; private set; }

    }

    public class Engine
    {

    }

    public enum TYPE
    {
        City,
        Sport,
        Suv
    }
}
