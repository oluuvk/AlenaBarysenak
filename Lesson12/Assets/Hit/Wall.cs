using UnityEngine;

public class Wall : MonoBehaviour, IHitable
{
    public void Hit()
    {
        Debug.Log("�� ���� ���� �����, � ������");
    }
}
