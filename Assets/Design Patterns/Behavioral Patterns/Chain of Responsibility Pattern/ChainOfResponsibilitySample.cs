using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ChainOfResponsibility
{
    public class ChainOfResponsibilitySample : MonoBehaviour
    {
        void Start()
        {
            AbstractHandler calc1 = new CheckNull();
            AbstractHandler calc2 = new CheckNumberOfString();
            AbstractHandler calc3 = new CheckUpperCase();

            calc1.SetNext(calc2);
            calc2.SetNext(calc3);

            Debug.Log($"Handle \"String\"");
            calc1.Handle("String");

            Debug.Log($"Handle \"Null\"");
            calc1.Handle("Null");

            Debug.Log($"Handle \"My Name Is Unity\"");
            calc1.Handle("My Name Is Unity");

            Debug.Log($"Handle null");
            calc1.Handle(null);
        }
    }
}
