using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody _rb;
    public void Fly(Vector3 _direction)
    {
        _rb.AddForce(_direction * 50, ForceMode.Impulse);
    }
}
