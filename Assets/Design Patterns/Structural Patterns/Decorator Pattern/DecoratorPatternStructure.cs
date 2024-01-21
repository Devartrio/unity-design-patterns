using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Decorator
{
    public class DecoratorPatternStructure : MonoBehaviour
    {
        void Start()
        {
            ConcreteComponent concreteComponent = new ConcreteComponent();
            ConcreteDecoratorA concreteDecoratorA = new ConcreteDecoratorA();
            ConcreteDecoratorB concreteDecoratorB = new ConcreteDecoratorB();

            concreteDecoratorA.SetComponent(concreteComponent);
            concreteDecoratorB.SetComponent(concreteDecoratorA);

            concreteDecoratorB.Operation();
        }
    } 

    /// <summary>
    /// The Component abstract class
    /// </summary>
    abstract class Component
    {
        public abstract void Operation();
    }

    /// <summary>
    /// The ConcreteComponent class
    /// </summary>
    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Debug.Log("ConcreteComponent.Operation()");
        }
    }

    /// <summary>
    /// The Decorator abstract class
    /// </summary>
    abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            component?.Operation();
        }
    }

    /// <summary>
    /// The ConcreteDecoratorA calss
    /// </summary>
    class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Debug.Log("ConcreteDecoratorA.Operation()");
        }
    }

    /// <summary>
    /// The ConcreteDecoratorB class
    /// </summary>
    class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Debug.Log("ConcreteDecoratorB.Operation()");
        }
    }
}
