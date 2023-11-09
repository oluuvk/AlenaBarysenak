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
                Debug.Log($"����� ��� ����� {_mass.Amount}");
                _mass.Amount += collision.gameObject.GetComponent<Mass>().Amount;
                transform.localScale = new Vector3(_mass.Amount, _mass.Amount, _mass.Amount);
                Destroy(collision.gameObject);
                Debug.Log($"C��� {collision.gameObject.GetComponent<Mass>().Amount} � ���� " +
                    $"{_mass.Amount}");
            }
            if (_mass.Amount < collision.gameObject.GetComponent<Mass>().Amount)
            {
                Destroy(gameObject);
            }
        }
        else Debug.Log("� �������������� ������� ��� �����");
    }

    /* ������� �� ����������
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
