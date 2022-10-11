using System.Runtime.InteropServices;
using UnityEngine;

using VContainer;
using VContainer.Unity;

public class HomeLifetimeScope : LifetimeScope
{
    [SerializeField] HomeScene homeScene;
    
    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterEntryPoint<HomePresenter>(Lifetime.Singleton);
        builder.RegisterComponent(homeScene);
    }
}
