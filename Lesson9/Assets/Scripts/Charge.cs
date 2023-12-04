using UnityEngine;

public class Charge : MonoBehaviour
{
    [SerializeField] Rigidbody _rb;
    public void Fly(Vector3 _direction, float _force)
    {
        _rb.AddForce(_direction * _force, ForceMode.Impulse);
    }
}