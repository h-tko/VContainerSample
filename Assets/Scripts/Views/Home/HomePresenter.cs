using UnityEngine;
using UnityEngine.SceneManagement;

using VContainer;
using VContainer.Unity;

public class HomePresenter : IStartable
{
    private HomeScene _homeScene;

    [Inject]
    public HomePresenter(HomeScene homeScene)
    {
        _homeScene = homeScene;
    }

    public void Start()
    {
        _homeScene.StartButton.onClick.AddListener(
            () => SceneManager.LoadScene("GameScene")
        );
    }
}
