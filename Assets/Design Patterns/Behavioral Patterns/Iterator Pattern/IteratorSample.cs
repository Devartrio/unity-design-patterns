using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Iterator
{
    public class IteratorSample : MonoBehaviour
    {
        void Start()
        {
            SongCollection songCollection = new SongCollection();

            songCollection.AddItem(new SongInfo("song title 1", "artist1", 2016));
            songCollection.AddItem(new SongInfo("song title 2", "artist2", 2016));
            songCollection.AddItem(new SongInfo("song title 3", "artist1", 2020));
            songCollection.AddItem(new SongInfo("song title 4", "artist2", 2021));
            songCollection.AddItem(new SongInfo("song title 5", "artist1", 2022));

            Debug.Log("Start Print SongCollection.");
            foreach (SongInfo item in songCollection)
            {
                Debug.Log(item.ToString());
            }

            Debug.Log("Start Print SongCollection in reverse.");
            songCollection.ReverseDirection();
            foreach (SongInfo item in songCollection)
            {
                Debug.Log(item.ToString());
            }
        }

    }
}
