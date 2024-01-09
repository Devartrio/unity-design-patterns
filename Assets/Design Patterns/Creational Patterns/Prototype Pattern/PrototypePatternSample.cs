using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace DesignPatterns.Prototype
{
    public class PrototypePatternSample : MonoBehaviour
    {
        void Start()
        {
            Player firstPlayer = new Player();
            firstPlayer.Age = 28;
            firstPlayer.Name = "Bae";
            firstPlayer.createdDate = DateTime.Now;
            firstPlayer.IdInfo = new IdInfo(12345678);

            // shallow copy
            Player secondPlayer = firstPlayer.ShallowCopy();
            // deep copy
            Player thirdPlayer = firstPlayer.DeepCopy();

            Debug.Log("Original values of first player:");
            DisplayValues(firstPlayer);
            Debug.Log("Original values of second player:");
            DisplayValues(secondPlayer);
            Debug.Log("Original values of third player:");
            DisplayValues(thirdPlayer);

            Debug.Log("---------------------------------------");

            firstPlayer.Age = 29;
            firstPlayer.Name = "Bae2";
            firstPlayer.createdDate = DateTime.Now.AddDays(1);
            firstPlayer.IdInfo.IdNumber = 87654321;

            Debug.Log("first player instance values");
            DisplayValues(firstPlayer);
            Debug.Log("second player instance values(shallow copy)");
            DisplayValues(secondPlayer);
            Debug.Log("third player instance values(deep copy)");
            DisplayValues(thirdPlayer);
        }

        public static void DisplayValues(Player p)
        {
            Debug.Log($"Name: {p.Name}, Age: {p.Age}, Id: {p.IdInfo.IdNumber}, CreatedDate: {p.createdDate}");
        }
    }

    public class Player
    {
        public int Age;
        public DateTime createdDate;
        public string Name;
        public IdInfo IdInfo;

        public Player ShallowCopy()
        {
            return (Player)this.MemberwiseClone();
        }

        public Player DeepCopy()
        {
            Player clone = (Player)this.MemberwiseClone();
            clone.Age = Age;
            clone.createdDate = createdDate;
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = String.Copy(Name);
            return clone;
        }
    }

    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            IdNumber = idNumber;
        }
    }


}
