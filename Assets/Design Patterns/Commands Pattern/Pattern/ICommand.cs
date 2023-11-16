using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Command
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}