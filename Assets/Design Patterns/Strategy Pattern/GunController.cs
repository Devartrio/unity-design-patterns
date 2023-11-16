using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Strategy
{
    public class GunController : MonoBehaviour
    {
        private IGunStrategy currentGunStrategy;

        private void Start()
        {
            SetStrategy(new Pistol());
            currentGunStrategy.Shoot();

            SetStrategy(new Machinegun());
            currentGunStrategy.Shoot();
        }

        public void SetStrategy(IGunStrategy strategy)
        {
            currentGunStrategy = strategy;
        }

    }
}
