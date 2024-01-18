using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Target : MonoBehaviour, IHitable
{
    public void Hit(Collision collision)
    {
        Destroy(gameObject);
    }
}

