using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Iterator
{
    public abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();
        public abstract int key();
        public abstract object Current();
        public abstract bool MoveNext();
        public abstract void Reset();

    }
}
