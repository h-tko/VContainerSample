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
            Mathf.Clamp(newPositionX, -14.2f, 14.2f),
            Mathf.Clamp(newPositionY, -3.6f, 3.6f),
            0f
        );

        // 押してる方向で画像を差し替える
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _playerSpriteRenderer.sprite = playerRightImage;
        } else if (Input.GetKey(KeyCode.LeftArrow))
        {
            _playerSpriteRenderer.sprite = playerLeftImage;
        } else if (Input.GetKey(KeyCode.UpArrow))
        {
            // 最大3倍までじわじわ大きくしていく
            if (transform.localScale.x <= 3.0f)
            {
                transform.localScale *= 1.01f;
                StartCoroutine(UndoPlayerScale());
            }
        } else {
            _playerSpriteRenderer.sprite = playerNormalImage;
        }
    }

    private IEnumerator UndoPlayerScale()
    {
        yield return new WaitForSeconds(1);

        transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
