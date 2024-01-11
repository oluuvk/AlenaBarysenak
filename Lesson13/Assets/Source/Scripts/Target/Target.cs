using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Target : MonoBehaviour
{
    public virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Bird>())
        {
            Destroy(collision.gameObject);
        }
    }
}

