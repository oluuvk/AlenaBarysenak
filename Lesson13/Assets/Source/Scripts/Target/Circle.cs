using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class Circle : MonoBehaviour, IHitable
{
    public void Hit()
    {
        transform.localScale = new Vector3(4, 4, 0.5f);
    }
}
