using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Mediator
{
    public class MediatorPatternSample : MonoBehaviour
    {
        void Start()
        {
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();
            new ConcreteMediator(component1, component2);

            Debug.Log("Client triggers operation A.");
            component1.DoA();

            Debug.Log("Client triggers operation D.");
            component2.DoD();


        }


    }
}
