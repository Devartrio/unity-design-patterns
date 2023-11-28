using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.FactoryMethod
{
    public class ConcreteProduct1 : Product
    {
        public ConcreteProduct1()
        {
            name = "ConcreteProduct1";
            Debug.Log("ConcreteProduct1 created");
        }
    }
}
