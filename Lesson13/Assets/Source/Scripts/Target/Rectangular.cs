using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class Rectangular : MonoBehaviour, IHitable
{
    public void Hit()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        renderer.material.color = new Color(0.48f, 0.57f, 0.87f, 0.67f);
    }
}
