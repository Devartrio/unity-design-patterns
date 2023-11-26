using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Debug.Log("ConcreteObserverA: Reacted to the event.");
            }
        }
    }

}