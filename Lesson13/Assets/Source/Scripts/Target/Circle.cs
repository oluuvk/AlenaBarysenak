using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class Circle : Target
{
    public override void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Bird>())
        {
            transform.localScale = new Vector3(4, 4, 0.5f);
        }
    }

}
