using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ChainOfResponsibility
{
    public class CheckNull : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request == null)
            {
                Debug.Log($"Request is NULL");
                return null;
            }
            else
                Debug.Log($"Request is not NULL");

            return base.Handle(request);
        }
    }
}
