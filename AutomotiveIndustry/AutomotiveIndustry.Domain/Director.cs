using System;
using System.Collections.Generic;
using System.Text;
using AutomotiveIndustry.Domain.Builders;

namespace AutomotiveIndustry.Domain
{
    public class Director
    {
        private IBuilder _builder;


        private IBuilder Builder
        {
            set { _builder = value; }
        }




    }
}
