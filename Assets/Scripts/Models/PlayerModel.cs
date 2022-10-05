using UnityEngine;

public interface IPlayerModel
{
    float GetNextPositionX(float currentX, float dx);
    float GetNextPositionY(float currentY, float dy);
}

public class PlayerModel : IPlayerModel
{
    public float GetNextPositionX(float currentX, float dx)
    {
        return currentX + (dx * Time.deltaTime * 9f);
    }

    public float GetNextPositionY(float currentY, float dy)
    {
        return currentY + (dy * Time.deltaTime * 9f);
    }
}