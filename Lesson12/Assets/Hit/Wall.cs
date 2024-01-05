using UnityEngine;

public class Wall : MonoBehaviour, IHitable
{
    public void Hit()
    {
        Debug.Log("Ты чего меня бьешь, я стенка");
    }
}
