using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DesignPatterns.FactoryMethod.ConcreteFactory;

namespace DesignPatterns.FactoryMethod
{
    public abstract class Factory
    {
        public abstract Product CreateProduct(ProductType productType);
    }
}
