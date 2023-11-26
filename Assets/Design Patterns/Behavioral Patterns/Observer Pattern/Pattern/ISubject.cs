using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public interface ISubject
    {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }
}
