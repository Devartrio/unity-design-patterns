using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.FactoryMethod
{
    public class FactoryMethodPatternSample : MonoBehaviour
    {
        ConcreteFactory factory = new ConcreteFactory();

        void Start()
        {
            factory.CreateProduct(ConcreteFactory.ProductType.Product1);

            factory.CreateProduct(ConcreteFactory.ProductType.Product2);

            factory.CreateProduct(ConcreteFactory.ProductType.Product1);
        }


    }
}
