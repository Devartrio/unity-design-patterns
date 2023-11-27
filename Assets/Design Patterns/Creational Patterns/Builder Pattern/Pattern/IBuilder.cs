using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Builder
{
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
    }
}
