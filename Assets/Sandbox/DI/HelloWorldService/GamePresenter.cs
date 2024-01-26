using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer.Unity;

public class GamePresenter : ITickable
{
    readonly HelloWorldService helloWorldService;

    public GamePresenter(HelloWorldService helloWorldService)
    {
        this.helloWorldService = helloWorldService;
    }

    void ITickable.Tick()
    {
        helloWorldService.Hello();
    }
}
