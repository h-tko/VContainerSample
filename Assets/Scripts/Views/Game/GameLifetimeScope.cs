using UnityEngine;

using VContainer;
using VContainer.Unity;

public class GameLifetimeScope : LifetimeScope
{
    [SerializeField] PlayerScript playerScript;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterEntryPoint<GamePresenter>(Lifetime.Singleton);
        builder.RegisterComponent(playerScript);
        builder.Register<IPlayerModel, PlayerModel>(Lifetime.Singleton);
    }
}
