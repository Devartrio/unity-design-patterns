using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Iterator
{
    public class SongInfo
    {
        public string songName { get; protected set; }

        public string bandName { get; protected set; }

        public int yearReleased { get; protected set; }

        public SongInfo(string songName, string bandName, int yearReleased)
        {
            this.songName = songName;
            this.bandName = bandName;
            this.yearReleased = yearReleased;
        }

        public override string ToString()
        {
            return this.songName + " - " + this.bandName + " : " + this.yearReleased.ToString();
        }
    }
}
