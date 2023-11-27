using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Builder
{
    public class Director
    {
        private IBuilder builder;

        public IBuilder Builder
        {
            set { builder = value; }
        }

        public void BuildMinimalViableProduct()
        {
            builder.BuildPartA();
        }

        public void BuildFullFeaturedProduct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }

        public void BuildCustomProduct()
        {
            builder.BuildPartB();
            builder.BuildPartC();
        }

    }
}
