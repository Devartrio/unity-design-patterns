using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Visitor
{
    public class VisitorPatternSample : MonoBehaviour
    {
        IVisitor visitorA = new ConcreteVisitorA();
        IVisitor visitorB = new ConcreteVisitorB();

        ObjectStructure objectStructure = new ObjectStructure();
        void OnEnable()
        {
            objectStructure.Attach(new ConcreteElementA());
            objectStructure.Attach(new ConcreteElementB());

            objectStructure.Accept(visitorA);
            objectStructure.Accept(visitorB);
        }
    }

    public interface IVisitor
    {
        void Visit(IElement element);
    }

    public class ConcreteVisitorA : IVisitor
    {
        public void Visit(IElement element)
        {
            Debug.Log("ConcreteVisitorA visited " + element.GetType().Name);
        }
    }

    public class ConcreteVisitorB : IVisitor
    {
        public void Visit(IElement element)
        {
            Debug.Log("ConcreteVisitorB visited " + element.GetType().Name);
        }
    }

    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

    public class ConcreteElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void OperationA()
        {
            Debug.Log("ConcreteElementA.OperationA()");
        }
    }

    public class ConcreteElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void OperationB()
        {
            Debug.Log("ConcreteElementB.OperationB()");
        }
    }

    public class ObjectStructure
    {
        private List<IElement> elements = new List<IElement>();

        public void Attach(IElement element)
        {
            elements.Add(element);
        }

        public void Detach(IElement element)
        {
            elements.Remove(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (IElement element in elements)
            {
                element.Accept(visitor);
            }
        }
    }


}
