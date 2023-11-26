using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Iterator
{
    public interface IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}