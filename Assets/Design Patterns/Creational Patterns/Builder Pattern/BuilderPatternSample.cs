using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Builder
{
    public class BuilderPatternSample : MonoBehaviour
    {
        void Start()
        {
            Director director = new Director();
            ConcreteBuilder builder = new ConcreteBuilder();
            director.Builder = builder;

            Debug.Log("Standard basic product:");
            director.BuildMinimalViableProduct();
            Debug.Log(builder.GetProduct().ListParts());

            Debug.Log("Standard full featured product:");
            director.BuildFullFeaturedProduct();
            Debug.Log(builder.GetProduct().ListParts());

            Debug.Log("Custom product:");
            director.BuildCustomProduct();
            Debug.Log(builder.GetProduct().ListParts());

            Debug.Log("Custom product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Debug.Log(builder.GetProduct().ListParts());
        }
    }
}
