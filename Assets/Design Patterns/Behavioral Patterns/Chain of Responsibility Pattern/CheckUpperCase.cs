using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ChainOfResponsibility
{
    public class CheckUpperCase : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.GetType() == typeof(string))
            {
                string requestedString = (string)request;
                string upperCaseChacter = "";
                for (int i = 0; i < requestedString.Length; i++)
                {
                    if (char.IsUpper(requestedString[i]))
                        upperCaseChacter += " " + requestedString[i];
                }

                Debug.Log($"UpperCase is {upperCaseChacter}.");
            }
            else
                Debug.Log($"Object is not string");

            return base.Handle(request);
        }
    }
}
