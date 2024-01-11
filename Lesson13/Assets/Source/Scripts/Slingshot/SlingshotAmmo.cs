using System.Collections;
using UnityEngine;
public class SlingshotAmmo : MonoBehaviour
{
    [SerializeField] private float _maxAmmo;
    [SerializeField] private float _delay=1;
    [SerializeField] private ShootPoint _point;
    [SerializeField] private BirdsFactory _factory;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Transform _startPosition;

    private float _currentAmmo;
    private void Awake()
    {
       _currentAmmo = _maxAmmo;
        NextBird();
        _point.OnRealizeShoot += NextBird;
    } 
    private void NextBird()
    {
        if (_currentAmmo == 0)
            return;
        _currentAmmo--;
        StartCoroutine(ReloadTick());
    }
    private void CreateBird()
    {
        Bird newBird = _factory.CreateBird(_spawnPoint.position);
        newBird.SetUp(_point.transform, _startPosition);
        _point.UpdateBird(newBird);
    }
    private IEnumerator ReloadTick()
    {
        yield return new WaitForSeconds(_delay);
        CreateBird(); 
    }
}
