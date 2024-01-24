using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Flyweight
{
    public class FlyweightPatternStructure : MonoBehaviour
    {
        void Start()
        {
            int externalState = 22;

            FlyweightFactory factory = new FlyweightFactory();

            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--externalState);

            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--externalState);

            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--externalState);

            UnsharedConcreteFlyweight fu = new
              UnsharedConcreteFlyweight();

            fu.Operation(--externalState);
        }
    }

    /// <summary>
    /// The 'FlyweightFactory' class
    /// </summary>
    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> flyweights = new Dictionary<string, Flyweight>();

        public FlyweightFactory()
        {
            flyweights.Add("X", new ConcreteFlyweight());
            flyweights.Add("Y", new ConcreteFlyweight());
            flyweights.Add("Z", new ConcreteFlyweight());
        }

        public Flyweight GetFlyweight(string key)
        {
            return flyweights[key];
        }
    }

    /// <summary>
    /// The 'Flyweight' abstract class
    /// </summary>
    public abstract class Flyweight
    {
        public abstract void Operation(int extrinsicstate);
    }

    /// <summary>
    /// The 'ConcreteFlyweight' class
    /// </summary>
    class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int externalState)
        {
            Debug.Log("ConcreteFlyweight: " + externalState);
        }
    }

    /// <summary>
    /// The 'UnsharedConcreteFlyweight' class
    /// </summary>
    class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int externalState)
        {
            Debug.Log("UnsharedConcreteFlyweight: " + externalState);
        }
    }
}
