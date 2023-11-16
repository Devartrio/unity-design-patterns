using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Strategy
{
    public class Pistol : IGunStrategy
    {
        public void Shoot()
        {
            Debug.Log("권총 빵야");
        }


    }
}
