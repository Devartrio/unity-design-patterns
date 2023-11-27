using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Mediator
{
    class ConcreteMediator : IMediator
    {
        private Component1 component1;
        private Component2 component2;

        public ConcreteMediator(Component1 component1, Component2 component2)
        {
            this.component1 = component1;
            this.component1.SetMediator(this);
            this.component2 = component2;
            this.component2.SetMediator(this);
        }

        public void Notify(object sender, string ev)
        {
            switch (ev)
            {
                case "A":
                    Debug.Log("Mediator reacts on A and triggers following operations:");
                    this.component2.DoC();
                    break;

                case "D":
                    Debug.Log("Mediator reacts on D and triggers following operations:");
                    this.component1.DoB();
                    this.component2.DoC();
                    break;
                case
                    "C":
                    Debug.Log("Mediator reacts on C and triggers following operations:");
                    this.component1.DoB();
                    break;
                default:
                    break;
            }
        }
    }
}
