using UnityEngine;
using System.Collections;

using VContainer;
using VContainer.Unity;

public sealed class GamePresenter : ITickable
{
    private readonly PlayerScript _player;
    private readonly IPlayerModel _playerModel;

    [Inject]
    public GamePresenter(PlayerScript player, IPlayerModel playerModel)
    {
        _player = player;
        _playerModel = playerModel;
    }

    // Update is called once per frame
    public void Tick()
    {
        float dx = Input.GetAxis("Horizontal");
        float dy = Input.GetAxis("Vertical");

        float nextX = _playerModel.GetNextPositionX(_player.transform.position.x, dx);
        float nextY = _playerModel.GetNextPositionY(_player.transform.position.y, dy);

        _player.MovePosition(nextX, nextY);
    }
}
