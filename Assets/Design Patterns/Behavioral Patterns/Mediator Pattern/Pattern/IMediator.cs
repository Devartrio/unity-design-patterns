using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Mediator
{
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
}