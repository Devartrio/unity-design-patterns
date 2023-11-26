using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.State
{
    public class Character : MonoBehaviour
    {
        public CharacterState characterState;

        private void Start()
        {
            StartCoroutine(IEStateUpdate());
        }

        IEnumerator IEStateUpdate()
        {
            while (true)
            {
                yield return new WaitForSeconds(1f);
                characterState?.Idle();
            }
        }

        void ChangeState()
        {

        }
    }
}
