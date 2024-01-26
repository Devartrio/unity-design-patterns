using VContainer;
using VContainer.Unity;

public class HelloWorldLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<HelloWorldService>(Lifetime.Singleton);
        builder.RegisterEntryPoint<GamePresenter>();
        //builder.Register<GamePresenter>(Lifetime.Singleton);
    }
}
