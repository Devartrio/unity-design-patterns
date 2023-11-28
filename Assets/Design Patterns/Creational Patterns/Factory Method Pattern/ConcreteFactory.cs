using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.FactoryMethod
{
    public class ConcreteFactory : Factory
    {
        public enum ProductType
        {
            Product1,
            Product2
        }

        public override Product CreateProduct(ProductType productType)
        {
            switch (productType)
            {
                case ProductType.Product1:
                    return new ConcreteProduct1();
                case ProductType.Product2:
                    return new ConcreteProduct2();
                default:
                    return null;
            }
        }

    }
}
