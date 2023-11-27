using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Mediator
{
    class Component2 : BaseComponent
    {
        public void DoC()
        {
            Debug.Log("Component 2 does C.");

            this.mediator.Notify(this, "C");
        }

        public void DoD()
        {
            Debug.Log("Component 2 does D.");

            this.mediator.Notify(this, "D");
        }
    }
}
