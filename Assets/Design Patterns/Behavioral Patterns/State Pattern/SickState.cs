using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.State
{
    public class SickState : CharacterState
    {
        public override void Idle()
        {
            Debug.Log("Sick Idle");
        }

        public override void Jump()
        {
            Debug.Log("Sick Jump");
        }

        public override void Run()
        {
            Debug.Log("Sick Run");
        }

        public override void Walk()
        {
            Debug.Log("Sick Walk");
        }

    }

}