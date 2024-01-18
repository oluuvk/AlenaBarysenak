using UnityEngine;

public class PlayerAttact : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<IHitable>(out IHitable ihitable))
        {
            ihitable.Hit();
        }
    }
}
