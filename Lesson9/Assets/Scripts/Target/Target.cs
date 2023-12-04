using UnityEngine;

public class Target : MonoBehaviour
{
    public virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Charge>())
        {
            Destroy(collision.gameObject);
        }
    }
}
