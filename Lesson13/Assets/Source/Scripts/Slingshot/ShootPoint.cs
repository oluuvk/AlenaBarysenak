using System;
using UnityEngine;

public class ShootPoint : MonoBehaviour
{
    public Action OnRealizeShoot;

    [SerializeField] private float _maxDistance=2;
    private Bird _bird;
    private Camera _camera;
    private Vector2 _start;
    private void Awake()
    {
        _camera = Camera.main;   
        _start = transform.position;
    }
    public void UpdateBird(Bird bird)
    {
        _bird = bird;
    }
    private void OnMouseDrag()
    {
        Vector2 target = _camera.ScreenToWorldPoint(Input.mousePosition);
        if (Vector2.Distance(_start, target) < _maxDistance)
        {
            transform.position = target;
        }
        else
        {
            Vector2 direction = (target - _start).normalized * _maxDistance;
            transform.position = _start + direction;
        }
    }
    private void OnMouseUp()
    {
        Vector2 releasePosition = transform.position;
        transform.position = _start;
        Vector2 delta = releasePosition - _start;
        _bird.Launch(-delta*5);
        OnRealizeShoot?.Invoke();
        //_bird = null;
    }
    
}
