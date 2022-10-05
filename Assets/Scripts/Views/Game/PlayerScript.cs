using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private SpriteRenderer _playerSpriteRenderer;

    public Sprite playerNormalImage;
    public Sprite playerLeftImage;
    public Sprite playerRightImage;

    void Start()
    {
        _playerSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    public void MovePosition(float newPositionX, float newPositionY)
    {
        transform.position = new Vector3(
            newPositionX,
            newPositionY,
            0f
        );

        // 押してる方向で画像を差し替える
        if (Input.GetKey(KeyCode.RightArrow)) {
            _playerSpriteRenderer.sprite = playerRightImage;
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            _playerSpriteRenderer.sprite = playerLeftImage;
        } else {
            _playerSpriteRenderer.sprite = playerNormalImage;
        }
    }
}
