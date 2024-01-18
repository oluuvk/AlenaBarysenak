using UnityEngine;

public class PlayerAttact : MonoBehaviour
{
    private void OnCollisionEnter2D (Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<IHitable>(out IHitable ihitable))
        {
            ihitable.Hit();
        }
    }
}
