using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ChainOfResponsibility
{
    public class CheckNumberOfString : AbstractHandler
    {
        public override object Handle(object request)
        {
            if(request.GetType() == typeof(string))
                Debug.Log($"Number of String is {((string)request).Length}");
            else
                Debug.Log($"Object is not string");

            return base.Handle(request);
        }
    }
}
