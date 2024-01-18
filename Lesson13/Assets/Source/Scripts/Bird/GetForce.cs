using UnityEngine;

public class GetForce : MonoBehaviour
{
    private Bird _bird;
    private Rigidbody2D _rb;
    private void Awake()
    {
        _bird = gameObject.GetComponent<Bird>();
        _rb = _bird.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(_rb.velocity * 3, ForceMode2D.Impulse);
        }
    }
}
