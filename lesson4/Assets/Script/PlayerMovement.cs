using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Mass _mass;
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.velocity = Vector3.left*2;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.velocity = Vector3.right*2;
        }
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.velocity = Vector3.forward*2;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rigidbody.velocity = Vector3.back*2;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Mass>())
        {
            if (_mass.Amount > collision.gameObject.GetComponent<Mass>().Amount)
            {
                Debug.Log($"Игрок был массы {_mass.Amount}");
                _mass.Amount += collision.gameObject.GetComponent<Mass>().Amount;
                transform.localScale = new Vector3(_mass.Amount, _mass.Amount, _mass.Amount);
                Destroy(collision.gameObject);
                Debug.Log($"Cъел {collision.gameObject.GetComponent<Mass>().Amount} и стал " +
                    $"{_mass.Amount}");
            }
            if (_mass.Amount < collision.gameObject.GetComponent<Mass>().Amount)
            {
                Destroy(gameObject);
            }
        }
        else Debug.Log("У соприкосаемого объекта нет массы");
    }

    /* задание со звездочкой
       if (collision.gameObject.GetComponent<Mass>())
       {
          if (_mass.Amount > collision.gameObject.GetComponent<Mass>().Amount)
           {
            collision.transform.position = new Vector3(0,1,0);
           }
          else 
           {
            transform.position = new Vector3(0,1,0);
           }
        }
    */
}
