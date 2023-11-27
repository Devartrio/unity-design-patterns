using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Mediator
{
    class Component1 : BaseComponent
    {
        public void DoA()
        {
            Debug.Log("Component 1 does A.");

            mediator.Notify(this, "A");
        }

        public void DoB()
        {
            Debug.Log("Component 1 does B.");

            mediator.Notify(this, "B");
        }
    }

}