using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Iterator
{
    public class AlphabeticalOrderIterator : Iterator
    {
        private SongCollection collection;

        private int position = -1;

        private bool reverse = false;

        public AlphabeticalOrderIterator(SongCollection collection, bool reverse = false)
        {
            this.collection = collection;
            this.reverse = reverse;

            if (reverse)
            {
                this.position = collection.getItems().Count;
            }
        }

        public override object Current()
        {
            return collection.getItems()[position];
        }

        public override int key()
        {
            return position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = position + (reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < collection.getItems().Count)
            {
                position = updatedPosition;
                return true;
            }
            else
                return false;
        }

        public override void Reset()
        {
            position = reverse ? collection.getItems().Count - 1 : 0;
        }
    }
}
