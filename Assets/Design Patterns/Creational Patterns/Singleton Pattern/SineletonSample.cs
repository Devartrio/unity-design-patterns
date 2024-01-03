using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Singleton
{
    public class SineletonSample : MonoBehaviour
    {
        private void Start()
        {
            Car.Instance.TurnOn();
        }
    }

    public class  Car : Singleton<Car>
    {
        public void TurnOn()
        {
            Debug.Log("Car is on");
        }
    }
}
