using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _rotate;
    [SerializeField] private float _clainX, _clainY;
    private void Update()
    {
        float _horizontal = Input.GetAxis("Horizontal");
        float _vertical = Input.GetAxis("Vertical");
        _rotate.x = Mathf.Clamp(_rotate.x, -_clainX, _clainX);
        _rotate.y = Mathf.Clamp(_rotate.y, -_clainY, _clainY);
        _rotate += new Vector3(-_vertical, _horizontal, 0);
        transform.rotation = Quaternion.Euler(_rotate * _speed);
    }
}
