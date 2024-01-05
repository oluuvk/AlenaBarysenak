using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] protected private Ball _ball;
    [SerializeField] protected private Transform _spawnPoint;
    [SerializeField] protected private int _maxAmmo;
    public Action OnShoot;
    [field: SerializeField] public int Ammo { get; protected private set; }

    protected private void CreatedBall()
    {
        Ball BallCreated = Instantiate(_ball, _spawnPoint.position, Quaternion.identity).GetComponent<Ball>();
        BallCreated.Fly(_spawnPoint.transform.forward);
        Ammo--;
    }
    
    public virtual void Shoot()
    {
        if (Ammo == 0)
            return;
        OnShoot+=CreatedBall;
        OnShoot?.Invoke();
        StartCoroutine(Delay());
        OnShoot -= CreatedBall;
    }
    public void Reload()
    {
        StartCoroutine(ReloadTick());
    }
    protected private IEnumerator Delay()
    {
        yield return new WaitForSeconds(1.2f);
    }
    private IEnumerator ReloadTick()
    {
        yield return new WaitForSeconds(1.5f);
        Ammo = _maxAmmo;
    }
    

}
