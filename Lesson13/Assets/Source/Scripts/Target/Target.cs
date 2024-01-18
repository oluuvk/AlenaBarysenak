using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Target : MonoBehaviour, IHitable
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }
    public void Hit(Collision2D collision)
    {
        OnCollisionEnter2D(collision);
    }
}

