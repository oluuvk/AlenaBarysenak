using UnityEngine;

public class Barrel : MonoBehaviour, IHitable
{
    public void Hit()
    {
        Destroy(gameObject);
    }
}
