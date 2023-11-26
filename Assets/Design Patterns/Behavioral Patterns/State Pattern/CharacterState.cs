using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.State
{
    public abstract class CharacterState : MonoBehaviour
    {
        public abstract void Idle();
        public abstract void Walk();
        public abstract void Run();
        public abstract void Jump();
    }
}
