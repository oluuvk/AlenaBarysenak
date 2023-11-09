using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody _rb;
    private void Fly(Vector3 _direction, float _force)
    {
        _rb.AddForce(_direction * _force, ForceMode.Impulse);
    }
}
