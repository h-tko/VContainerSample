using UnityEngine;
using UnityEngine.SceneManagement;

using VContainer;
using VContainer.Unity;

public class HomePresenter : IStartable
{
    private readonly HomeScene _homeScene;

    [Inject]
    public HomePresenter(HomeScene homeScene)
    {
        _homeScene = homeScene;
    }

    public void Start()
    {
        _homeScene.startButton.onClick.AddListener(
            () => SceneManager.LoadScene("GameScene")
        );
    }
}
