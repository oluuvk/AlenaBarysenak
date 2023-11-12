using UnityEngine;

public class Push : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody, _rigidbodyEnemy;
    [SerializeField] private Mass _mass;
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.velocity = Vector3.left * 2;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.velocity = Vector3.right * 2;
        }
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.velocity = Vector3.forward * 2;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rigidbody.velocity = Vector3.back * 2;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        _rigidbodyEnemy = collision.gameObject.GetComponent<Rigidbody>();
        if (collision.gameObject.GetComponent<Mass>())
        {
            if (gameObject.GetComponent<Mass>().Amount > collision.gameObject.GetComponent<Mass>().Amount)
            {
                Vector3 moveDistance = (collision.transform.position - transform.localPosition);
                _rigidbodyEnemy.AddForce(moveDistance * 50, ForceMode.Impulse);
            }
            else
            {
                Vector3 moveDistance = (transform.localPosition - collision.transform.position);
                _rigidbody.AddForce(moveDistance * 50, ForceMode.Impulse);
            }
        }
    }
}
