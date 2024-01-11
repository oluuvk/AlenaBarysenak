using DG.Tweening;
using TMPro;
using UnityEngine;
using static System.Net.WebRequestMethods;
using static UnityEngine.GraphicsBuffer;

[RequireComponent(typeof(Rigidbody2D))]

public class Bird : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Transform _target;
    private bool _isActive=false;
    public float a=200;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.isKinematic = true;
    }
    private void Update()
    {
        if (_isActive)
        {
            transform.position = _shootPoint.position;
        }
    }
    public void SetUp(Transform shootPoint, Transform startPoint)
    {
        _shootPoint = shootPoint;
        transform.DOJump(shootPoint.position, 1, 1, 1).OnComplete(() =>
        {
            _isActive = true;
        });
    }
    public void Launch(Vector2 direction)
    {
        _isActive = false;
        _rigidbody.isKinematic = false;
        _rigidbody.AddForce(direction, ForceMode2D.Impulse);
    }
    public void GetAcceleration()
    {
        transform.position = Vector2.MoveTowards(transform.position, _target.position, a * Time.deltaTime);
    }
}
