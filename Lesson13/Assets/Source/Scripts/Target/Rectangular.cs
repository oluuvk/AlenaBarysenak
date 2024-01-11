using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class Rectangular : Target
{
    public override void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Bird>())
        {
            transform.gameObject.GetComponent<MeshRenderer>().material.color = new Color(0.48f, 0.57f, 0.87f, 0.67f);
        }
    }
}
