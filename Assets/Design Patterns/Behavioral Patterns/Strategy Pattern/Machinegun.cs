using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Strategy
{
    public class Machinegun : IGunStrategy
    {
        public void Shoot()
        {
            Debug.Log("머신건 두두두");
        }
    }
}
