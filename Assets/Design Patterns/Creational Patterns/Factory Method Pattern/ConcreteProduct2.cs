using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.FactoryMethod
{
    public class ConcreteProduct2 : Product
    {
        public ConcreteProduct2()
        {
            name = "ConcreteProduct2";
            Debug.Log("ConcreteProduct2 created");
        }
    }
}
