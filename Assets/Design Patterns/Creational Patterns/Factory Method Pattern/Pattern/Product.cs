using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.FactoryMethod
{
    public abstract class Product
    {
        public string name;

        public void Display()
        {
            Debug.Log("Product: " + name);
        }
    }
}
