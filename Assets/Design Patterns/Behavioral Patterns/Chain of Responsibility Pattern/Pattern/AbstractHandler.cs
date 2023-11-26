using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ChainOfResponsibility
{
    public class AbstractHandler : IHandler
    {
        private IHandler nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            nextHandler = handler;

            return handler;
        }

        public virtual object Handle(object request)
        {
            if (this.nextHandler != null)
                return nextHandler.Handle(request);
            else
                return null;
        }

    }
}
