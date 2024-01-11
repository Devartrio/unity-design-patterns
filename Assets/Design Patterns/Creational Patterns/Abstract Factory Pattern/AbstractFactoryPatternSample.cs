using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.AbstractFactory
{
    public class AbstractFactoryPatternSample : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Client: Testing client code with the first factory type...");
            ClientMethod(new ConcreteFactory1());
            Debug.Log("");

            Debug.Log("Client: Testing the same client code with the second factory type...");
            ClientMethod(new ConcreteFactory2());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Debug.Log(productB.UsefulFunctionB());
            Debug.Log(productB.AnotherUsefulFunctionB(productA));
        }

    }

    public interface IAbstractFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }

    public class ConcreteFactory1 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA1();
        }

        public IProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    public class ConcreteFactory2 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA2();
        }

        public IProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    public interface IProductA
    {
        string UsefulFunctionA();
    }

    public class ProductA1 : IProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A1.";
        }
    }

    public class ProductA2 : IProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A2.";
        }
    }

    public interface IProductB
    {
        string UsefulFunctionB();
        string AnotherUsefulFunctionB(IProductA collaborator);
    }

    public class ProductB1 : IProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B1.";
        }

        public string AnotherUsefulFunctionB(IProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();
            return $"The result of the B1 collaborating with the ({result})";
        }
    }

    public class ProductB2 : IProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B2.";
        }

        public string AnotherUsefulFunctionB(IProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();
            return $"The result of the B2 collaborating with the ({result})";
        }
    }

}
