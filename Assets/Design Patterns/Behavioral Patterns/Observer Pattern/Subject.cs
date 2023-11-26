using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public class Subject : MonoBehaviour, ISubject
    {
        public int State { get; set; } = -0;

        [SerializeField] private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Debug.Log("Subject: Attached an observer.");
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Debug.Log("Subject: Detached an observer.");
        }

        public void Notify()
        {
            Debug.Log("Subject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void SomeLogic()
        {
            Debug.Log("Subject: I'm doing something important.");
            State = Random.Range(0, 10);

            Debug.Log("Subject: My state has just changed to: " + this.State);
            Notify();
        }

        private void Start()
        {
            ConcreteObserverA concreteObserverA = new ConcreteObserverA();
            ConcreteObserverB concreteObserverB = new ConcreteObserverB();

            Attach(concreteObserverA);
            Attach(concreteObserverB);

            SomeLogic();

            Detach(concreteObserverB);

            SomeLogic();
        }
    }
}
