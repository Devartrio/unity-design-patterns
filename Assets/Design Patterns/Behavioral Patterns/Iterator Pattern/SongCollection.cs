using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Iterator
{
    public class SongCollection : IteratorAggregate
    {
        List<SongInfo> collection = new List<SongInfo>();

        bool direction = false;

        public void ReverseDirection()
        {
            direction = !direction;
        }

        public List<SongInfo> getItems()
        {
            return collection;
        }

        public void AddItem(SongInfo item)
        {
            collection.Add(item);
        }

        public IEnumerator GetEnumerator()
        {
            //foreach (SongInfo song in collection)
            //{
            //    yield return song;
            //}
            return new AlphabeticalOrderIterator(this, direction);
        }
    }
}
