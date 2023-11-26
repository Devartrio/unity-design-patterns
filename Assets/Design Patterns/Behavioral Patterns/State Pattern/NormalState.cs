using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.State
{
    public class NormalState : CharacterState
    {
        public override void Idle()
        {
            Debug.Log("Normal Idle");
        }

        public override void Jump()
        {
            Debug.Log("Normal Jump");
        }

        public override void Run()
        {
            Debug.Log("Normal Run");
        }

        public override void Walk()
        {
            Debug.Log("Normal Walk");
        }

    }
}
