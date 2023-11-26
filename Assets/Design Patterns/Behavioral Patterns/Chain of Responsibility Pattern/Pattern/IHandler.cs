using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ChainOfResponsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object Handle(object request);
    }

}