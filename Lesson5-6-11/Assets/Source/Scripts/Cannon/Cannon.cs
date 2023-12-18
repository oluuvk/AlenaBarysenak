using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] protected private Ball _ball;
    [SerializeField] protected private Transform _spawnPoint;
    [SerializeField] protected private int _maxAmmo;
    [field: SerializeField] public bool CanShoot { get; protected private set; }
    [field: SerializeField] public int Ammo { get; protected private set; }

    public virtual void Shoot()
    {
        Ball BallCreated = Instantiate(_ball, _spawnPoint.position, Quaternion.identity).GetComponent<Ball>();
        BallCreated.Fly(_spawnPoint.transform.forward, 50);
        Ammo--;
        CanShoot = false;
        StartCoroutine(Delay());
    }
    public void Reload()
    {
        CanShoot = false;
        StartCoroutine(ReloadTick());
    }
    protected private IEnumerator Delay()
    {
        yield return new WaitForSeconds(1.2f);
        CanShoot = true;
    }
    private IEnumerator ReloadTick()
    {
        yield return new WaitForSeconds(1.5f);
        Ammo = _maxAmmo;
        CanShoot = true;
    }
}
