using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Decorator
{
    public class DecoratorPatternSample : MonoBehaviour
    {
        private void Start()
        {
            IPizza basicPizza = new TomatoSauce(new Mozzarella(new PlainPizza()));
            Debug.Log("Ingredients of Pizza : " + basicPizza.GetDescription());
            Debug.Log("Total Cosst : " + basicPizza.GetCost());
        }
    } 

    public interface IPizza
    {
        string GetDescription();
        double GetCost();
    }

    public class PlainPizza : IPizza
    {
        public string GetDescription()
        {
            return "Thin Dough";
        }

        public double GetCost()
        {
            return 4.00;
        }
    }

    public abstract class ToppingDecorator : IPizza
    {
        protected IPizza tempPizza;

        public ToppingDecorator(IPizza newPizza)
        {
            this.tempPizza = newPizza;
        }

        public virtual string GetDescription()
        {
            return tempPizza.GetDescription();
        }

        public virtual double GetCost()
        {
            return tempPizza.GetCost();
        }
    }

    public class Mozzarella : ToppingDecorator
    {
        public Mozzarella(IPizza newPizza) : base(newPizza)
        {
            Debug.Log("Adding Dough");
            Debug.Log("Adding Morarella");
        }

        public override string GetDescription()
        {
            return tempPizza.GetDescription() + ", Mozzarella";
        }

        public override double GetCost()
        {
            return tempPizza.GetCost() + 0.50;

        }
    }

    public class TomatoSauce : ToppingDecorator
    {
        public TomatoSauce(IPizza newPizza) : base(newPizza)
        {
            Debug.Log("Adding Sauce");
        }

        public override string GetDescription()
        {
            return tempPizza.GetDescription() + ", Tomato Sauce";
        }

        public override double GetCost()
        {
            return tempPizza.GetCost() + 0.35;
        }
    }
}
