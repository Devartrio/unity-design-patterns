using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}


//https://refactoring.guru/ko/design-patterns/observer/csharp/example